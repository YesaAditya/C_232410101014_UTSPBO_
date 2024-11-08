using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_232410101014_UTSPBO_
{
    public partial class Form2 : Form
    {
        List<Inventaris> inventaris = new List<Inventaris>();
        public Form2()
        {
            InitializeComponent();
  
            Inventaris inventaris1 = new Inventaris();
            inventaris1.NamaBarang = "Apel";
            inventaris1.Kategori = "Buah";
            inventaris1.Jumlah = 5;
            inventaris1.Harga = 2000;
            inventaris.Add(inventaris1);

            dataGridView1.DataSource = inventaris;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
