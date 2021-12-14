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
        List<Data> dataList = new List<Data>();
        public Form1()
        {
            InitializeComponent();
            Updatelist();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                      
        }

        private void Updatelist(Data selData = null)
        {
            dataList.Clear();
            foreach(var itm in Program.logic.GetData())
                dataList.Add(itm);
            dataGridView1.DataSource = dataList;

            /*if (selData != null)
            {
                Data dt = dataList.FirstOrDefault(x => x.ID == selData.ID);
                dataGridView1.CurrentRow.DataGridView.DataSource = dt;
            }*/
        }

               
        private void btAdd_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            FormADD FA = new FormADD(data);
            if(FA.ShowDialog() == DialogResult.OK)
                Program.logic.AddData(data);
        }
        
        private void btUpdate_Click(object sender, EventArgs e)
        {
            Updatelist();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Data dt = (Data)dataGridView1.CurrentRow.DataBoundItem;
            if(dt != null)
            {
                Data selData = dataList.FirstOrDefault(x => x.ID == dt.ID);
                FormADD FA = new FormADD(selData);
                if (FA.ShowDialog() == DialogResult.OK)
                    Program.logic.UpdateRecord(selData);
            }
        }
    }
}
