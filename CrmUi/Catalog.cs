using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CrmUi
{
    public partial class Catalog<T> : Form
        where T : class
    {


        public Catalog(DbSet<T> set)
        {
            InitializeComponent();
            dataGridView1.DataSource = set.Local.ToBindingList();
        }

      

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 