using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisTakip
{
    public partial class fkullaniciyetki : Form
    {
       
        
        public fkullaniciyetki()
        {
            InitializeComponent();
           
        }
       
        private void fkullaniciyetki_Load(object sender, EventArgs e)
        {
           
        }
        private void fkullaniciyetki_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            //Fanasayfa f = new Fanasayfa("Demo");
            //f.Show();
            Application.Exit();
        }

        
    }
}
