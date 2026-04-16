using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDatabaseMySQL;
using System.IO;

namespace MelodexAdmin
{
    internal class Options
    {
        public string Host { get; set; }
        public string FNév { get; set; }
        public string Jelszó { get; set; }
        public Options(string host, string fNév, string jelszó)
        {
            Host = host;
            FNév = fNév;
            Jelszó = jelszó;
        }
    }

    internal static class Közös
    {
        public static string FájlNévBeállítások = "options.txt";

        public static bool AdatbázisKapcsolódásEllenőrzése(string host, string fnév, string jelszó)
        {
            try
            {
                MyDB kapcs = new MyDB($"server={host};userid={fnév};password={jelszó};charset=utf8;database=melodex");
                kapcs.Open();
                kapcs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Options KapcsolódásiAdatokBeolvasása()
        {
            try
            {
                if (File.Exists(FájlNévBeállítások))
                {
                    StreamReader f = new StreamReader(FájlNévBeállítások);
                    string host = f.ReadLine();
                    string fnév = f.ReadLine();
                    string jelszó = f.ReadLine();
                    f.Close();
                    host = Encoding.UTF8.GetString(Convert.FromBase64String(host));
                    fnév = Encoding.UTF8.GetString(Convert.FromBase64String(fnév));
                    jelszó = Encoding.UTF8.GetString(Convert.FromBase64String(jelszó));
                    return new Options(host, fnév, jelszó);
                }
                else
                {
                    return new Options("", "", "");
                }
            }
            catch (Exception)
            {
                return new Options("", "", "");
                //throw;
            }
        }

        public static void KapcsolódásiAdatokTárolása(string host, string fnév, string jelszó)
        {
            try
            {
                StreamWriter f = new StreamWriter(FájlNévBeállítások);
                f.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(host)));
                f.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(fnév)));
                f.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(jelszó)));
                f.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
