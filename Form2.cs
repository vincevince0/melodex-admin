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
        private List<Members> members = new List<Members>();
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

        private void slct_users_Click(object sender, EventArgs e)
        {

        }

        private void slct_albums_Click(object sender, EventArgs e)
        {
            string sql = "";
            sql = "SELECT * from albums";

        }

        private void slct_songs_Click(object sender, EventArgs e)
        {

        }

        private void slct_members_Click(object sender, EventArgs e)
        {

        }

        private void slct_artists_Click(object sender, EventArgs e)
        {

        }

        private void slct_reports_Click(object sender, EventArgs e)
        {

        }
    }
}
