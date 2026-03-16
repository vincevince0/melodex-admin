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
        public melodex_admin()
        {
            InitializeComponent();
        }

        private void melodex_admin_Load(object sender, EventArgs e)
        {

        }

        private void init()
        {
            Options options = Közös.KapcsolódásiAdatokBeolvasása();
            kapcs = new MyDB($"server={options.Host};userid={options.FNév};password={options.Jelszó};charset=utf8;database=melodex");
        }
    }
}
