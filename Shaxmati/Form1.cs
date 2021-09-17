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
            for (int ColumNum = 0; ColumNum < 8; ColumNum++) 
            {
                for (int RowNum = 0; RowNum < 8; RowNum++)
                {
                    if (ColumNum % 2 == 0)
                    {
                        if (RowNum % 2 == 0)
                            dataGridView1.Rows[ColumNum].Cells[RowNum].Style.BackColor = Color.Brown;
                        else
                            dataGridView1.Rows[ColumNum].Cells[RowNum].Style.BackColor = Color.Black;
                    }
                    else
                    {
                        if (RowNum % 2 == 0)
                            dataGridView1.Rows[ColumNum].Cells[RowNum].Style.BackColor = Color.Black;
                        else
                            dataGridView1.Rows[ColumNum].Cells[RowNum].Style.BackColor = Color.Brown;
                    }
                }
                dataGridView1.Rows[ColumNum].Height = 100;
                dataGridView1.Columns[ColumNum].Width = 100;
            }

            
        }

        /*private void setupChessField()
        {
                dataGridView1.RowCount = 8;
                for (int i = 0; i < 8; i++)
                {
                    dataGridView1.Rows[i].Height = 100;
                    dataGridView1.Columns[i].Width = 100;
                }
        }*/

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
