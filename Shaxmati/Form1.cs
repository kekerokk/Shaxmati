using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaxmati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 8;
            for (int i = 0; i < 8; i++) 
            {
                dataGridView1.Rows[i].Height = 100;
                dataGridView1.Columns[i].Width = 100;
            }

            
        }

        private void setupChessField()
        {
                dataGridView1.RowCount = 8;
                for (int i = 0; i < 8; i++)
                {
                    dataGridView1.Rows[i].Height = 100;
                    dataGridView1.Columns[i].Width = 100;
                }
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 8;
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Rows[i].Height = 100;
                dataGridView1.Columns[i].Width = 100;
            }


        }*/
    }
}
