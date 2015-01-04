using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exceltest
{
    public partial class ShowResault : Form
    {
        wslist r;
        string keyword = "";
        public ShowResault(wslist resault, string keyword)
        {
            InitializeComponent();
            r = resault;
            this.keyword = keyword;
            dataGridView1.DataSource = (from f in r
                                        orderby f.Point descending, f.Distanse ascending
                                        select f).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowResault_Load(object sender, EventArgs e)
        {

        }

    }
}
