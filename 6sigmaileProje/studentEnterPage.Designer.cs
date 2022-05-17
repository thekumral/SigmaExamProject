
namespace _6sigmaileProje
{
    partial class studentEnterPage
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
            this.elipseStudentEnter = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControlStudentEnter = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnGoExamModule = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // elipseStudentEnter
            // 
            this.elipseStudentEnter.BorderRadius = 30;
            this.elipseStudentEnter.TargetControl = this;
            // 
            // dragControlStudentEnter
            // 
            this.dragControlStudentEnter.DockIndicatorTransparencyValue = 0.6D;
            this.dragControlStudentEnter.TargetControl = this;
            this.dragControlStudentEnter.UseTransparentDrag = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.lblWelcome.Location = new System.Drawing.Point(191, 75);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(637, 42);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the 6Sigma exam prepation software";
            // 
            // btnReport
            // 
            this.btnReport.BorderRadius = 8;
            this.btnReport.BorderThickness = 5;
            this.btnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnReport.Location = new System.Drawing.Point(325, 284);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(365, 64);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Show report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnGoExamModule
            // 
            this.btnGoExamModule.BorderRadius = 8;
            this.btnGoExamModule.BorderThickness = 5;
            this.btnGoExamModule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGoExamModule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGoExamModule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGoExamModule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGoExamModule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.btnGoExamModule.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGoExamModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnGoExamModule.Location = new System.Drawing.Point(325, 194);
            this.btnGoExamModule.Name = "btnGoExamModule";
            this.btnGoExamModule.Size = new System.Drawing.Size(365, 64);
            this.btnGoExamModule.TabIndex = 2;
            this.btnGoExamModule.Text = "Go To Exam Module";
            this.btnGoExamModule.Click += new System.EventHandler(this.btnGoExamModule_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(104, 577);
            this.guna2Panel1.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.guna2Panel2.Location = new System.Drawing.Point(914, -1);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(104, 577);
            this.guna2Panel2.TabIndex = 4;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // studentEnterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(1019, 577);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnGoExamModule);
            this.Controls.Add(this.btnReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "studentEnterPage";
            this.Text = "studentEnterPage";
            this.Load += new System.EventHandler(this.studentEnterPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseStudentEnter;
        private Guna.UI2.WinForms.Guna2DragControl dragControlStudentEnter;
        private Guna.UI2.WinForms.Guna2Button btnGoExamModule;
        private Guna.UI2.WinForms.Guna2Button btnReport;
        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}