using System;
using System.Collections;
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
    public partial class Ftanim : Form
    {
        public Ftanim()
        {
            InitializeComponent();
        }

        private void Ftanim_Load(object sender, EventArgs e)
        {

        }
        SqlSorgu s = new SqlSorgu();
        List<Entities.Etanimmarka> Lmarka;
        List<Entities.Etanimmodel> Lmodel;
        private void Ttanimmarka_CheckedChanged(object sender, EventArgs e)
        {
            Ltanim.Text = "Tanım : Marka";
            Ltanim.Name = "Ttanimmarka";
            Lmarka = s.markacek();
            if (Lmarka != null)
                dataGridView1.DataSource = Lmarka;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Marka";
        }

        private void rmodel_CheckedChanged(object sender, EventArgs e)
        {
            Ltanim.Text = "Tanım : Model";
            Ltanim.Name = "Ttanimmodel";
            Lmodel = s.modelcek();
            if (Lmodel != null)
                dataGridView1.DataSource = Lmodel;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Model";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Marka";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Ltanim.Name == "Ttanimmarka")
            {
                DialogResult dr = MessageBox.Show("Markaya bağlı modellerde silinecektir kabul ediyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    tanimsil();
                }
            }

        }

        private void tanimsil()
        {
            DialogResult rd = MessageBox.Show("Eminmisiniz? ", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rd == DialogResult.Yes)
            {
                int ids = 0;


                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    ids = Convert.ToInt32(row.Cells[0].Value);

                }

                int result = s.tanimsil(ids, Ltanim.Name.ToString());
                if (result == 0)
                {
                    MessageBox.Show("Başarısız İşlem", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 1)
                    MessageBox.Show("Başarılı İşlem", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Veritabanı Hatası", "Kritik", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
        private int tanimduzenle()
        {
            int ids = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                ids = Convert.ToInt32(row.Cells[0].Value);
                ttanimduzenekle.Text=row.Cells[1].Value.ToString();
            }
            return ids;
        }
        private void seçiliSatırıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bkaydet.Text = "Düzenle";
          bkaydet.Tag=  tanimduzenle();
        }

        private void bkaydet_Click(object sender, EventArgs e)
        {
            if (bkaydet.Tag!=null)
            {
                int id=Convert.ToInt32(bkaydet.Tag);
               int result= s.tanimguncelle(id, Ltanim.Name, ttanimduzenekle.Text);
                dataGridView1.Refresh();
            }
        }
    }
}
