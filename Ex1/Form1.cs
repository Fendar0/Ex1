using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ModelDBContainer db = new ModelDBContainer())
            {
                dataGridView1.DataSource = db.DataSet.Select(x => x).ToList();
            }               
        }
               
        private void btAdd_Click(object sender, EventArgs e)
        {
            FormADD add = new FormADD(selectbt: "Add");
            add.ShowDialog();
            Hide();
            Show();
        }

        private void btRemov_Click(object sender, EventArgs e)
        {
            FormADD add = new FormADD(selectbt: "Rem");
            add.ShowDialog();
            Hide();
            Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            FormADD add = new FormADD(selectbt: "Ed");
            add.ShowDialog();
            Hide();
            Show();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Program.logic.RowIndex = e.RowIndex;
        }
    }
}
