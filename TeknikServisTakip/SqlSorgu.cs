using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace TeknikServisTakip
{
    public class SqlSorgu
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-M4K4KM14;Initial Catalog=DbTeknikServis;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        List<string> kullaniciadlari;
        system.Foksiyonlar f;
        ArrayList sqlkolonlari;
        Entities.Ekullanicilar Ekullanicilar;
        Entities.Etanimmodel Etanimmodel;
        List<Entities.Etanimmarka> etmarka;
        List<Entities.Etanimmodel> etmodel;
        internal List<string> kullaniciadigonder()
        {
            try
            {
                cmd = new SqlCommand("Select kullaniciadi From Tkullanicilar", con);
                con.Open();
                reader = cmd.ExecuteReader();
                kullaniciadlari = new List<string>();
                while (reader.Read())
                {

                    kullaniciadlari.Add(reader[0].ToString());
                }
                con.Close();
                reader.Close();
                return kullaniciadlari;
            }
            catch (Exception)
            {

                throw;
            }

        }
        internal int kullaniciadikontrol(string kuladi, string sifre)
        {
            int result = 0;
            try
            {

                cmd = new SqlCommand("Select * From TKullanicilar where kullaniciadi = @usr AND sifre = @pass", con);
                cmd.Parameters.AddWithValue("@usr", kuladi);
                cmd.Parameters.AddWithValue("@pass", sifre);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = Convert.ToInt32(reader[0]);
                    con.Close();
                    reader.Close();
                    return result;
                }
                else
                {
                    con.Close();
                    reader.Close();
                    return -101;

                }
            }
            catch (Exception)
            {
                return -202;
                throw;


            }

        }
        public SqlSorgu()
        {
            f = new system.Foksiyonlar();
        }
        internal int sifredegistir(int id, string yenisifre)
        {
            int result = 0;
            try
            {
                cmd = new SqlCommand("Update Tkullanicilar set sifre=@sifre where id=@id", con);
                cmd.Parameters.AddWithValue("@sifre", yenisifre);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                result = cmd.ExecuteNonQuery();
                con.Close();
                return result;
            }
            catch (Exception)
            {
                result = -202;
                throw;
            }


        }
        internal Entities.Ekullanicilar kullanicibilgilerigonder(int id)
        {
            try
            {
                cmd = new SqlCommand("Select * From Tkullanicilar where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                reader = cmd.ExecuteReader();
                Ekullanicilar = new Entities.Ekullanicilar();
                if (reader.Read())
                {
                    Ekullanicilar.id = id;
                    Ekullanicilar.kullaniciadi = reader[1].ToString();
                    Ekullanicilar.sifre = reader[2].ToString();
                    Ekullanicilar.servisgorev = reader[3].ToString();
                    Ekullanicilar.cihazkayit = Convert.ToBoolean(reader[4]);
                    Ekullanicilar.smsrapor = Convert.ToBoolean(reader[5]);
                    Ekullanicilar.disservisrapor = Convert.ToBoolean(reader[6]);
                    Ekullanicilar.gunsonurapor = Convert.ToBoolean(reader[7]);
                    Ekullanicilar.grafikselrapor = Convert.ToBoolean(reader[8]);
                    Ekullanicilar.servisgenelrapor = Convert.ToBoolean(reader[9]);
                    Ekullanicilar.detaylisorgurapor = Convert.ToBoolean(reader[10]);
                    Ekullanicilar.kasagelirgiris = Convert.ToBoolean(reader[11]);
                    Ekullanicilar.kasagidergiris = Convert.ToBoolean(reader[12]);
                    Ekullanicilar.serviskasarapor = Convert.ToBoolean(reader[13]);
                    Ekullanicilar.odemegirisyapar = Convert.ToBoolean(reader[14]);
                    Ekullanicilar.odemegirissiler = Convert.ToBoolean(reader[15]);
                    Ekullanicilar.kasadetaygorur = Convert.ToBoolean(reader[16]);
                    Ekullanicilar.carihesapsondurum = Convert.ToBoolean(reader[17]);
                    Ekullanicilar.cariodemegirisi = Convert.ToBoolean(reader[18]);
                    Ekullanicilar.cariodemeraporu = Convert.ToBoolean(reader[19]);
                    Ekullanicilar.odemetarihidegisir = Convert.ToBoolean(reader[20]);
                    Ekullanicilar.kasagelirgirisisil = Convert.ToBoolean(reader[21]);
                    Ekullanicilar.kasagidergirisisil = Convert.ToBoolean(reader[22]);
                    Ekullanicilar.parcagirisi = Convert.ToBoolean(reader[23]);
                    Ekullanicilar.parcasatisi = Convert.ToBoolean(reader[24]);
                    Ekullanicilar.parcaislemleri = Convert.ToBoolean(reader[25]);
                    Ekullanicilar.parcahareketleri = Convert.ToBoolean(reader[26]);
                    Ekullanicilar.parcagarantitakip = Convert.ToBoolean(reader[27]);
                    Ekullanicilar.faturaliparcaraporu = Convert.ToBoolean(reader[28]);
                    Ekullanicilar.parcacikisyap = Convert.ToBoolean(reader[29]);
                    Ekullanicilar.parcagirisyap = Convert.ToBoolean(reader[30]);
                    Ekullanicilar.yeniparcatanimla = Convert.ToBoolean(reader[31]);
                    Ekullanicilar.parcabilgiguncelle = Convert.ToBoolean(reader[32]);
                    Ekullanicilar.tanimliparcasil = Convert.ToBoolean(reader[33]);
                    Ekullanicilar.bayiislemleri = Convert.ToBoolean(reader[34]);
                    Ekullanicilar.teksmsgonder = Convert.ToBoolean(reader[35]);
                    Ekullanicilar.toplusmsgonder = Convert.ToBoolean(reader[36]);
                    Ekullanicilar.yedekcihazislem = Convert.ToBoolean(reader[37]);
                    Ekullanicilar.genelayarlar = Convert.ToBoolean(reader[38]);
                    Ekullanicilar.kullaniciayarlari = Convert.ToBoolean(reader[39]);
                    Ekullanicilar.yazdirmaayarlari = Convert.ToBoolean(reader[40]);
                    Ekullanicilar.smsgondermeayarlari = Convert.ToBoolean(reader[41]);
                    Ekullanicilar.servisbilgileri = Convert.ToBoolean(reader[42]);
                    Ekullanicilar.müsteribilgileri = Convert.ToBoolean(reader[43]);
                    Ekullanicilar.cihazbilgileri = Convert.ToBoolean(reader[44]);
                    Ekullanicilar.servisislemleri = Convert.ToBoolean(reader[45]);
                    Ekullanicilar.ücretbilgisi = Convert.ToBoolean(reader[46]);
                    Ekullanicilar.kasahesabi = Convert.ToBoolean(reader[47]);
                    Ekullanicilar.smsgonderebilir = Convert.ToBoolean(reader[48]);
                    Ekullanicilar.parcaekleyebilir = Convert.ToBoolean(reader[49]);
                    Ekullanicilar.cihazkaydisilebilir = Convert.ToBoolean(reader[50]);
                    Ekullanicilar.tarihleridegistirebilir = Convert.ToBoolean(reader[51]);
                    Ekullanicilar.kullanilanparcayisilebilir = Convert.ToBoolean(reader[52]);
                    con.Close();
                    reader.Close();
                    return Ekullanicilar;
                }
                else
                {
                    con.Close();
                    reader.Close();
                    Ekullanicilar.id = -202;
                    return Ekullanicilar;

                }

            }
            catch (Exception)
            {
                con.Close();
                reader.Close();
                Ekullanicilar.id = -202;
                return Ekullanicilar;
                throw;
            }
        }
        internal int kullaniciekle(Entities.Ekullanicilar k)
        {
            int result = 0;
            try
            {
                cmd = new SqlCommand("insert into TKullanicilar (kullaniciadi, sifre, servisgorev, odemegirissiler, kasadetaygorur, kasagelirgirisisil, kasagidergirisisil, kullaniciayarlari, cihazkaydisilebilir, tarihleridegistirebilir, kullanilanparcayisilebilir) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", con);
                cmd.Parameters.AddWithValue("@p1", k.kullaniciadi);
                cmd.Parameters.AddWithValue("@p2", k.sifre);
                cmd.Parameters.AddWithValue("@p3", k.servisgorev);
                cmd.Parameters.AddWithValue("@p4", k.odemegirissiler);
                cmd.Parameters.AddWithValue("@p5", k.kasadetaygorur);
                cmd.Parameters.AddWithValue("@p6", k.kasagelirgiris);
                cmd.Parameters.AddWithValue("@p7", k.kasagidergirisisil);
                cmd.Parameters.AddWithValue("@p8", k.kullaniciayarlari);
                cmd.Parameters.AddWithValue("@p9", k.cihazkaydisilebilir);
                cmd.Parameters.AddWithValue("@p10", k.tarihleridegistirebilir);
                cmd.Parameters.AddWithValue("@p11", k.kullanilanparcayisilebilir);
                con.Open();
                result = cmd.ExecuteNonQuery();
                con.Close();
                return result;
            }
            catch (Exception)
            {
                result = -202;
                con.Close();
                return result;
                throw;
            }

        }

        internal int kullaniciguncelle(Entities.Ekullanicilar k)
        {
            cmd = new SqlCommand(f.kullaniciguncellesqlstringolustur(), con);
            sqlkolonlari = f.kolonsayisi();
            for (int i = 0; i <= sqlkolonlari.Count; i++)
            {
                // cmd.Parameters.AddWithValue($"@p{i+1}", k.(sqlkolonlari[i]));
            }

            int result = 0;
            return result;
        } // Devam Edilecek

        internal List<Entities.Etanimmarka> markacek()
        {
            cmd = new SqlCommand("select * from Ttanimmarka", con);
            con.Open();
            etmarka = new List<Entities.Etanimmarka>();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                etmarka.Add(new Entities.Etanimmarka()
                {
                    id = reader.GetInt32(0),
                    marka = reader.GetString(1),
                });
            }
            con.Close();
            reader.Close();
            return etmarka;
        }
        internal List<Entities.Etanimmodel> modelcek()
        {
            etmarka = markacek();
            cmd = new SqlCommand("select * from Ttanimmodel", con);
            con.Open();
            reader = cmd.ExecuteReader();
            etmodel = new List<Entities.Etanimmodel>();
            while (reader.Read())
            {

                etmodel.Add(new Entities.Etanimmodel()
                {
                    id = reader.GetInt32(0),
                    model = reader.GetString(1),
                    markaid = reader.GetInt32(2)
                });
            }
            con.Close();
            reader.Close();

            for (int i = 0; i < etmodel.Count; i++)
            {
                int markaid = etmodel[i].markaid;
                for (int j = 0; j < etmarka.Count; j++)
                {
                    if (etmarka[j].id == markaid)
                    {
                        etmodel[i].marka = etmarka[j].marka;
                        break;
                    }
                }
            }
            return etmodel;

        }

        internal int tanimsil(int id, string sqltablo)
        {
            int result = 0;
            if (sqltablo == "Ttanimmarka")
            {
                try
                {
                    cmd = new SqlCommand("delete from Ttanimmodel where markaid=@p1", con);
                    cmd.Parameters.AddWithValue("@p1", id);
                    con.Open();
                    result = cmd.ExecuteNonQuery();
                    if (result==0)
                    {
                        cmd.CommandText = "delete from Ttanimmarka where id=@p1";
                        cmd.Connection = con;
                       
                        result = cmd.ExecuteNonQuery();
                       
                        con.Close();
                        
                    }
                    else
                    {
                        con.Close();
                    }
                }
                catch (Exception)
                {

                    result = -202;
                }
            }
            return result;
        }
        internal int tanimguncelle(int id,string sqltablo,string yenideger,int markaid=0)
        {
            int result = 0;
            if (markaid==0)
            {
                if (sqltablo=="Ttanimmarka")
                {
                    cmd = new SqlCommand($"update  {sqltablo} set markaadi=@p1 where id=@p2", con);
                    cmd.Parameters.AddWithValue("@p1", yenideger);
                    cmd.Parameters.AddWithValue("@p2", id);
                    con.Open();
                    result = cmd.ExecuteNonQuery();
                   
                }
            }
            else
            {
                cmd=new SqlCommand("update Ttanimmodel set model=@p1,markaid=@p2 where id=@p3",con);
                cmd.Parameters.AddWithValue("@p1", yenideger);
                cmd.Parameters.AddWithValue("@p2",markaid);
                cmd.Parameters.AddWithValue("@p3",id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            return result;
        }


    }

}

/*
 
"update Tkullanicilar set kullaniciadi=@p1,sifre=p2,servisgorev=@p3,cihazkayit=@p5" +
",smsrapor=@p6,disservisrapor=@p7,gunsonurapor=@p8,grafikselrapor=@p9,servisgenelrapor=@p10,detaylisorgurapor=@p11,kasagelirgiris=@p12,kasagidergiris=@p13," +
"serviskasarapor=@p14,odemegirisyapar=@p15,odemegirissiler=@p16,kasadetaygorur=@p17,carihesapsondurum=@p18," +
"cariodemegirisi=@p19,cariodemeraporu=@20,odemetarihidegisir=@21,kasagelirgirisisil=@p22,kasagidergirisisil=@p23," +
"parcagirisi=@p24,parcasatisi=@p25,parcaislemleri=@p26,parcahareketleri=@p27,parcagarantitakip=@p28,faturaliparcaraporu=æp29," +
"parcacikisyap=@p30,parcagirisyap=@p31,yeniparcatanimla=@p32,parcabilgiguncelle=@p33,tanimliparcasil=@p34," +
"bayiislemleri=@p35,teksmsgonder=@p36,toplusmsgonder=@p37,yedekcihazislem=@p38,genelayarlar=@p39,kullaniciayarlari=@p40," +
"yazdirmaayarlari=@p41,smsgondermeayarlari=@p42,servisbilgileri=@p43,müsteribilgileri=@p44,cihazbilgileri=@p45," +
"servisislemleri=@p46,ücretbilgisi=@p47,kasahesabi=@p48,smsgonderebilir=@p49,parcaekleyebilir=@p50,cihazkaydisilebilir=@p51," +
"tarihleridegistirebilir=@p52,kullanilanparcayisilebilir=@p53 where id=@id"
 
 */