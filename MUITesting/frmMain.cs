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
using System.Windows.Forms.VisualStyles;

namespace MUITesting
{
    public partial class frmMain : Form
    {
        private Point[] points = { new Point(10, 10), new Point(20, 10), new Point(40, 10) };

        public frmMain()
        {
            InitializeComponent();
        }

        private void muiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (muiComboBox1.SelectedIndex == 0)
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
            dataGridView1.Rows.Add("Pepsi", "Drink", "1234567890");
            dataGridView1.Rows.Add("Cocacola", "Drink", "1234567890");
            dataGridView1.Rows.Add("7up", "7up", "1234567890");
            dataGridView1.Rows.Add("Fruity", "Drink", "1234567890");
            dataGridView1.Rows.Add("Soda", "Drink", "1234567890");
            dataGridView1.Rows.Add("Miranda", "Drink", "1234567890");
            dataGridView1.Rows.Add("Sprite", "Drink", "1234567890");
            dataGridView1.Rows.Add("Rani", "Drink", "1234567890");
            dataGridView1.Rows.Add("Mango", "Drink", "1234567890");

        }

        private void muiTextBox6_Text_Changed(object sender, EventArgs e)
        {
            Console.WriteLine(muiTextBox1.Text);
        }
    }
}
