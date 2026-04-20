using Google.Protobuf.WellKnownTypes;
using MyDatabaseMySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace MelodexAdmin
{
    public partial class melodex_admin : Form
    {
        private MyDB kapcs;

        class Albums
        {
            public int id, year, artist_id;
            public string name, cover, genre;
        }
        class Artists
        {
            public int id;
            public string name, nationality, image, description;
            public bool is_band;
        }
        class Members
        {
            public int id;
            public string name, artist_id;
        }
        class Songs
        {
            public int id, album_id;
            public string name, lyrics, songwriter;
        }
        class Users
        {
            public int id;
            public string name, email; //password nem kell
        }
        
        private List<Albums> albums = new List<Albums>();
        private List<Artists> artists= new List<Artists>();
        private List<Songs> songs = new List<Songs>();
        private List<Users> users = new List<Users>();
        public melodex_admin()
        {
            InitializeComponent();
            init();
        }

        private void melodex_admin_Load(object sender, EventArgs e)
        {

        }

        private void init()
        {
            Options options = Közös.KapcsolódásiAdatokBeolvasása();
            kapcs = new MyDB($"server={options.Host};userid={options.FNév};password={options.Jelszó};charset=utf8;database=melodex");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_table_label.Text = "Jelenleg kiválasztott tábla: "+comboBox1.Text;
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // 1. Validation: Make sure something is selected
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Kérlek válassz ki egy táblát!");
                return;
            }

            try
            {
                // 2. Build the SQL query based on the ComboBox text
                string tableName = comboBox1.Text;
                string sql = $"SELECT * FROM {tableName}";

                // 3. Use your MyDB 'SelectDataTableGUI' method to get the data
                // This is the most efficient way to fill a DataGridView
                DataTable dt = kapcs.SelectDataTableGUI(sql);

                // 4. Bind the result to the DataGridView
                datagrid_items.DataSource = dt;
                datagrid_items.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a lekérdezés során: " + ex.Message);
            }
        }

        private void datagrid_items_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Clears previous selection and highlights the new row clearly
            datagrid_items.Rows[e.RowIndex].Selected = true;
            // Ignore header clicks
            if (e.RowIndex < 0) return;

            editPanel.Controls.Clear();
            DataGridViewRow selectedRow = datagrid_items.Rows[e.RowIndex];

            foreach (DataGridViewColumn col in datagrid_items.Columns)
            {
                // Create a small container for each Field
                Panel container = new Panel { Width = 180, Height = 45 };

                Label lbl = new Label
                {
                    Text = col.Name,
                    Dock = DockStyle.Top,
                    Font = new Font("Arial", 8, FontStyle.Bold)
                };

                TextBox txt = new TextBox
                {
                    Text = selectedRow.Cells[col.Index].Value?.ToString(),
                    Name = "txt_" + col.Name, // We use this name to find it later
                    Dock = DockStyle.Bottom
                };

                // Safety: Don't let users edit the 'id' column
                if (col.Name.ToLower() == "id") txt.Enabled = false;

                container.Controls.Add(lbl);
                container.Controls.Add(txt);
                editPanel.Controls.Add(container);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (datagrid_items.CurrentRow == null) return;

            string tableName = comboBox1.Text;
            string idValue = "";
            List<string> updateFields = new List<string>();

            // Find the TextBoxes we generated earlier
            foreach (Control container in editPanel.Controls)
            {
                TextBox txt = container.Controls.OfType<TextBox>().FirstOrDefault();
                if (txt != null)
                {
                    string fieldName = txt.Name.Replace("txt_", "");

                    if (fieldName.ToLower() == "id")
                        idValue = txt.Text;
                    else
                        //updateFields.Add($"`{fieldName}` = '{txt.Text}'");
                        updateFields.Add($"`{fieldName}` = '{txt.Text.Replace("'", "''")}'");
                }
            }

            string sql = $"UPDATE {tableName} SET {string.Join(", ", updateFields)} WHERE id = {idValue}";

            try
            {
                // 1. Open the connection using your class method
                kapcs.Open();

                // 2. Create the command using the now-public connection field
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, kapcs.connection);

                // 3. Execute
                cmd.ExecuteNonQuery();

                // 4. Close
                kapcs.Close();

                MessageBox.Show("Sikeres módosítás!");
                buttonOK_Click(null, null); // Refresh the grid
            }
            catch (Exception ex)
            {
                // Make sure we close the connection even if it fails
                kapcs.Close();
                MessageBox.Show("Hiba a mentés során: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. Find the ID from the generated textboxes in the editPanel
            // We named it "txt_id" or "txt_ID" in the CellClick event
            TextBox idTextBox = editPanel.Controls.Find("txt_id", true).FirstOrDefault() as TextBox;

            // Try uppercase if lowercase didn't work (depends on your DB column name)
            if (idTextBox == null)
                idTextBox = editPanel.Controls.Find("txt_ID", true).FirstOrDefault() as TextBox;

            if (idTextBox == null || string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Kérlek válassz ki egy sort a törléshez!");
                return;
            }

            string idValue = idTextBox.Text;
            string tableName = comboBox1.Text;

            var confirm = MessageBox.Show($"Biztosan törlöd a(z) {idValue} azonosítójú sort a(z) {tableName} táblából?",
                                        "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Use backticks around table name in case it's a reserved word
                    string sql = $"DELETE FROM `{tableName}` WHERE id = {idValue}";

                    kapcs.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, kapcs.connection);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    kapcs.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sikeresen törölve!");
                        editPanel.Controls.Clear(); // Clear the edit area since the record is gone
                        buttonOK_Click(null, null); // Refresh the grid
                    }
                    else
                    {
                        MessageBox.Show("A törlés nem sikerült. Nem található ilyen azonosító az adatbázisban.");
                    }
                }
                catch (Exception ex)
                {
                    kapcs.Close();
                    MessageBox.Show("Hiba a törlés során: " + ex.Message);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            editPanel.Controls.Clear();
        }
    }
}
