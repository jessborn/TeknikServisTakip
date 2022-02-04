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

namespace TeknikServisTakip
{
    public partial class Fsifredegistir : Form
    {

        int Id;
        public Fsifredegistir(int id)
        {
            InitializeComponent();
           
            Id = id;
        }
        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void Fsifredegistir_Load(object sender, EventArgs e)
        {

        }
    }
}
