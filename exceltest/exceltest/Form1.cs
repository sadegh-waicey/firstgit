using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace exceltest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileName = Application.StartupPath + @"\data.xlsx";
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;IMEX=1;HDR=NO;TypeGuessRows=0;ImportMixedType s=Text\"";
            var conn = new OleDbConnection(connectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM [Sheet1$]";
            var adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            wslist l = new wslist(dt);
            dataGridView1.DataSource = l;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.DataSource as wslist) == null)
                button1_Click(sender, e);
            (dataGridView1.DataSource as wslist).Calculate(
                (decimal)((decimal)trackBar1.Value / (decimal)100),
                (decimal)((decimal)trackBar2.Value / (decimal)100),
                (decimal)((decimal)trackBar3.Value / (decimal)100),
                (decimal)(-((decimal)trackBar4.Value / (decimal)100)),
                (decimal)((decimal)trackBar5.Value / (decimal)100),
                (decimal)((decimal)trackBar6.Value / (decimal)100),
                (decimal)(-((decimal)trackBar7.Value / (decimal)100)),
                checkBox1.Checked, checkBox3.Checked, checkBox2.Checked,
                (decimal)numericUpDown1.Value,
                (decimal)numericUpDown2.Value);
            new ShowResault((dataGridView1.DataSource as wslist),textBox1.Text).ShowDialog();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label9.Text = ((decimal)trackBar1.Value / (decimal)100).ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label10.Text = ((decimal)trackBar2.Value / (decimal)100).ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label11.Text = ((decimal)trackBar3.Value / (decimal)100).ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label12.Text = (-((decimal)trackBar4.Value / (decimal)100)).ToString();
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label13.Text = ((decimal)trackBar5.Value / (decimal)100).ToString();
//llkkii
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label14.Text = ((decimal)trackBar6.Value / (decimal)100).ToString();
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            label15.Text = (-((decimal)trackBar7.Value / (decimal)100)).ToString();
        }
    }
}
