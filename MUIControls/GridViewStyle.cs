using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUIControls
{
    public class GridViewStyle
    {
        public enum Style
        {
            Dark,
            Light
        }

        public GridViewStyle(DataGridView dgv, Style style)
        {
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10.0F, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10.0F);
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 40;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv.RowTemplate.Height = 40;
            dgv.RowTemplate.Resizable = DataGridViewTriState.False;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            switch (style)
            {
                case Style.Dark:
                    DarkStyle(dgv);
                    break;
                case Style.Light:
                    LightStyle(dgv);
                    break;
                default:
                    break;
            }
        }

        private  void DarkStyle(DataGridView dgv)
        {
            
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(33, 37, 41);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(114, 116, 118);
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;                      
            dgv.BackgroundColor = Color.FromArgb(43, 47, 52);                    
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 15, 17);            
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 15, 17);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;                     
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(43, 47, 52);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(114, 116, 118);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;                      
            dgv.Refresh();
        }

        private void LightStyle(DataGridView dgv)
        {
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(210, 232, 254);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.BackgroundColor = Color.FromArgb(248, 251, 254);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 254);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 254);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(248, 251, 254);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.Refresh();
        }
    }
}
