using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace TeknikServisTakip.system
{
    internal class Foksiyonlar
    {
        ArrayList kolonadlari;

        private void dosyaisimdegistir() //uzantı .msl olan dosyayı .txt ye dondurur.
        {

            FileInfo fi = new FileInfo(@"C:\masal\constants.msl");
            fi.MoveTo(@"C:\masal\constants.txt");
          
        }
        private void dosyaisimdegistir2()//uzantı .txt olan dosyayı .msl ye donusturur.
        {
            FileInfo fi = new FileInfo(@"C:\masal\constants.txt");
            fi.MoveTo(@"C:\masal\constants.msl");
        }
        private ArrayList kolonlarioku()
        {

            dosyaisimdegistir();
            using (StreamReader sr=new StreamReader(@"C:\masal\constants.txt"))
            {
                string line;
                kolonadlari= new ArrayList();
                while ((line = sr.ReadLine()) != null)
                {
                    kolonadlari.Add(line);
                }
            }
            dosyaisimdegistir2();
            return kolonadlari;
        }

        internal ArrayList kolonsayisi()
        {
         return   kolonadlari = kolonlarioku();

          
        }

        internal string kullaniciguncellesqlstringolustur()
        {
           kolonadlari= kolonlarioku(); 
            string sql="";

            for (int i = 1; i < kolonadlari.Count; i++)
            {
                sql = sql + $"{kolonadlari[i]}=@p{i},";
            }
            int len = sql.Length;
            sql = sql.Remove(len - 1, 1);
            sql = $"update Tkullanicilar set {sql} where id=@pid";
            return sql;
        }
    }
}
