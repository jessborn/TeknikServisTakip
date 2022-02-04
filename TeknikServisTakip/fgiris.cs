using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace TeknikServisTakip
{
    public partial class fgiris : Form
    {

        public fgiris()
        {
            InitializeComponent();


        }
        SqlSorgu Sorgu = new SqlSorgu();
        List<string> kullaniciadlari;
        private void Form1_Load(object sender, EventArgs e)
        {

            kullaniciadlari = Sorgu.kullaniciadigonder();
            ckuladi.DataSource = kullaniciadlari;
            Sorgu.modelcek();


        }
        private void bgiris_Click(object sender, EventArgs e)
        {
            int result = Sorgu.kullaniciadikontrol(ckuladi.SelectedItem.ToString(), tsifre.Text.ToString());
            MessageBox.Show(result.ToString());
        }

    }
}
