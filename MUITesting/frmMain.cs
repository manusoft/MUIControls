using MUIControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUITesting
{
    public partial class frmMain : Form   
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void muiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (muiComboBox1.SelectedIndex ==0 )
            {
                GridViewStyle darkTheme = new GridViewStyle(dataGridView1, GridViewStyle.Style.Dark);
            }
            else
            {
                GridViewStyle lightTheme = new GridViewStyle(dataGridView1, GridViewStyle.Style.Light);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Manoj", "Babu", "1234567890");
            dataGridView1.Rows.Add("Manoj", "Babu", "1234567890");
            dataGridView1.Rows.Add("Manoj", "Babu", "1234567890");
            dataGridView1.Rows.Add("Manoj", "Babu", "1234567890");
            dataGridView1.Rows.Add("Manoj", "Babu", "1234567890");
            dataGridView1.Rows.Add("Manoj", "Babu", "1234567890");
            dataGridView1.Rows.Add("Manoj", "Babu", "1234567890");
            dataGridView1.Rows.Add("Manoj", "Babu", "1234567890");
            dataGridView1.Rows.Add("Manoj", "Babu", "1234567890");

        }
    }
}
