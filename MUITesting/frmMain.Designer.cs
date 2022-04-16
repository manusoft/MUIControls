namespace MUITesting
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.muiButton1 = new MUIControls.muiButton();
            this.muiButton2 = new MUIControls.muiButton();
            this.muiButton3 = new MUIControls.muiButton();
            this.SuspendLayout();
            // 
            // muiButton1
            // 
            this.muiButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.muiButton1.BorderColor = System.Drawing.Color.Teal;
            this.muiButton1.BorderRadius = 15;
            this.muiButton1.BorderSize = 1;
            this.muiButton1.FlatAppearance.BorderSize = 0;
            this.muiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muiButton1.ForeColor = System.Drawing.Color.White;
            this.muiButton1.Location = new System.Drawing.Point(13, 13);
            this.muiButton1.Margin = new System.Windows.Forms.Padding(4);
            this.muiButton1.Name = "muiButton1";
            this.muiButton1.Size = new System.Drawing.Size(150, 30);
            this.muiButton1.TabIndex = 2;
            this.muiButton1.Text = "muiButton1";
            this.muiButton1.UseVisualStyleBackColor = false;
            // 
            // muiButton2
            // 
            this.muiButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.muiButton2.BorderColor = System.Drawing.Color.Teal;
            this.muiButton2.BorderRadius = 2;
            this.muiButton2.BorderSize = 1;
            this.muiButton2.FlatAppearance.BorderSize = 0;
            this.muiButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muiButton2.ForeColor = System.Drawing.Color.White;
            this.muiButton2.Location = new System.Drawing.Point(171, 13);
            this.muiButton2.Margin = new System.Windows.Forms.Padding(4);
            this.muiButton2.Name = "muiButton2";
            this.muiButton2.Size = new System.Drawing.Size(150, 30);
            this.muiButton2.TabIndex = 3;
            this.muiButton2.Text = "muiButton2";
            this.muiButton2.UseVisualStyleBackColor = false;
            // 
            // muiButton3
            // 
            this.muiButton3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.muiButton3.BorderColor = System.Drawing.Color.Teal;
            this.muiButton3.BorderRadius = 5;
            this.muiButton3.BorderSize = 1;
            this.muiButton3.FlatAppearance.BorderSize = 0;
            this.muiButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muiButton3.ForeColor = System.Drawing.Color.White;
            this.muiButton3.Location = new System.Drawing.Point(329, 13);
            this.muiButton3.Margin = new System.Windows.Forms.Padding(4);
            this.muiButton3.Name = "muiButton3";
            this.muiButton3.Size = new System.Drawing.Size(150, 30);
            this.muiButton3.TabIndex = 4;
            this.muiButton3.Text = "muiButton3";
            this.muiButton3.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.muiButton3);
            this.Controls.Add(this.muiButton2);
            this.Controls.Add(this.muiButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MUI Controls Tetsing";
            this.ResumeLayout(false);

        }

        #endregion
        private MUIControls.muiButton muiButton1;
        private MUIControls.muiButton muiButton2;
        private MUIControls.muiButton muiButton3;
    }
}

