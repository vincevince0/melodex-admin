namespace MelodexAdmin
{
    partial class melodex_admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagrid_items = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selected_table_label = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_items)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagrid_items);
            this.panel1.Location = new System.Drawing.Point(13, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 410);
            this.panel1.TabIndex = 0;
            // 
            // datagrid_items
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = null;
            this.datagrid_items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_items.Location = new System.Drawing.Point(3, 3);
            this.datagrid_items.Name = "datagrid_items";
            this.datagrid_items.Size = new System.Drawing.Size(953, 404);
            this.datagrid_items.TabIndex = 7;
            this.datagrid_items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "muveletek";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Users",
            "Albums",
            "Songs",
            "Artists",
            "Reports"});
            this.comboBox1.Location = new System.Drawing.Point(16, 12);
            this.comboBox1.MinimumSize = new System.Drawing.Size(10, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Műveletek";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // selected_table_label
            // 
            this.selected_table_label.AutoSize = true;
            this.selected_table_label.Location = new System.Drawing.Point(143, 15);
            this.selected_table_label.Name = "selected_table_label";
            this.selected_table_label.Size = new System.Drawing.Size(116, 13);
            this.selected_table_label.TabIndex = 9;
            this.selected_table_label.Text = "Nincs kiválasztva tábla";
            this.selected_table_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(894, 10);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // melodex_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.selected_table_label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "melodex_admin";
            this.Text = "Melodex Admin";
            this.Load += new System.EventHandler(this.melodex_admin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagrid_items;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label selected_table_label;
        private System.Windows.Forms.Button buttonOK;
    }
}