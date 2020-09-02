namespace Turbo_Tuners
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tmrCar = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.LblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrCar
            // 
            this.tmrCar.Enabled = true;
            this.tmrCar.Interval = 1;
            this.tmrCar.Tick += new System.EventHandler(this.tmrCar_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 414);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tmrCheck
            // 
            this.tmrCheck.Enabled = true;
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(575, 67);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Enabled = true;
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(575, 123);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(19, 13);
            this.LblTime.TabIndex = 2;
            this.LblTime.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrCheck;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.Label LblTime;
    }
}

