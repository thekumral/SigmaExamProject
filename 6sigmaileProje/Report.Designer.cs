
namespace _6sigmaileProje
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dragControlReport = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.elipseReportPage = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this._6SigmaDataSet2 = new _6sigmaileProje._6SigmaDataSet2();
            this.sigmaDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._6SigmaDataSet3 = new _6sigmaileProje._6SigmaDataSet3();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsTableAdapter = new _6sigmaileProje._6SigmaDataSet3TableAdapters.questionsTableAdapter();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.questionDataGrid = new System.Windows.Forms.DataGridView();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.questionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quetionImagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionMainSentenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionAnswerADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionAnswerBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionAnswerCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionAnswerDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTrueAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionNumberOfCorrectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionViewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._6SigmaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._6SigmaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dragControlReport
            // 
            this.dragControlReport.DockIndicatorTransparencyValue = 0.6D;
            this.dragControlReport.UseTransparentDrag = true;
            // 
            // elipseReportPage
            // 
            this.elipseReportPage.TargetControl = this;
            // 
            // _6SigmaDataSet2
            // 
            this._6SigmaDataSet2.DataSetName = "_6SigmaDataSet2";
            this._6SigmaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sigmaDataSet2BindingSource
            // 
            this.sigmaDataSet2BindingSource.DataSource = this._6SigmaDataSet2;
            this.sigmaDataSet2BindingSource.Position = 0;
            // 
            // _6SigmaDataSet3
            // 
            this._6SigmaDataSet3.DataSetName = "_6SigmaDataSet3";
            this._6SigmaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "questions";
            this.questionsBindingSource.DataSource = this._6SigmaDataSet3;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.questionDataGrid);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(437, 853);
            this.guna2Panel1.TabIndex = 1;
            // 
            // questionDataGrid
            // 
            this.questionDataGrid.AutoGenerateColumns = false;
            this.questionDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.questionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionIDDataGridViewTextBoxColumn,
            this.questionTitleDataGridViewTextBoxColumn,
            this.quetionImagePathDataGridViewTextBoxColumn,
            this.questionMainSentenceDataGridViewTextBoxColumn,
            this.questionAnswerADataGridViewTextBoxColumn,
            this.questionAnswerBDataGridViewTextBoxColumn,
            this.questionAnswerCDataGridViewTextBoxColumn,
            this.questionAnswerDDataGridViewTextBoxColumn,
            this.questionTrueAnswerDataGridViewTextBoxColumn,
            this.questionNumberOfCorrectDataGridViewTextBoxColumn,
            this.questionViewDataGridViewTextBoxColumn});
            this.questionDataGrid.DataSource = this.questionsBindingSource;
            this.questionDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(153)))), ((int)(((byte)(75)))));
            this.questionDataGrid.Location = new System.Drawing.Point(0, 0);
            this.questionDataGrid.Name = "questionDataGrid";
            this.questionDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.questionDataGrid.RowTemplate.Height = 30;
            this.questionDataGrid.Size = new System.Drawing.Size(437, 853);
            this.questionDataGrid.TabIndex = 0;
            this.questionDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(153)))), ((int)(((byte)(75)))));
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.btnBack.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(153)))), ((int)(((byte)(75)))));
            this.btnBack.Location = new System.Drawing.Point(620, 683);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(500, 53);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "BACK";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 15;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(620, 119);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(500, 500);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // questionIDDataGridViewTextBoxColumn
            // 
            this.questionIDDataGridViewTextBoxColumn.DataPropertyName = "questionID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.questionIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.questionIDDataGridViewTextBoxColumn.HeaderText = "Question ID";
            this.questionIDDataGridViewTextBoxColumn.Name = "questionIDDataGridViewTextBoxColumn";
            this.questionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // questionTitleDataGridViewTextBoxColumn
            // 
            this.questionTitleDataGridViewTextBoxColumn.DataPropertyName = "questionTitle";
            this.questionTitleDataGridViewTextBoxColumn.HeaderText = "questionTitle";
            this.questionTitleDataGridViewTextBoxColumn.Name = "questionTitleDataGridViewTextBoxColumn";
            this.questionTitleDataGridViewTextBoxColumn.Visible = false;
            // 
            // quetionImagePathDataGridViewTextBoxColumn
            // 
            this.quetionImagePathDataGridViewTextBoxColumn.DataPropertyName = "quetionImagePath";
            this.quetionImagePathDataGridViewTextBoxColumn.HeaderText = "quetionImagePath";
            this.quetionImagePathDataGridViewTextBoxColumn.Name = "quetionImagePathDataGridViewTextBoxColumn";
            this.quetionImagePathDataGridViewTextBoxColumn.Visible = false;
            // 
            // questionMainSentenceDataGridViewTextBoxColumn
            // 
            this.questionMainSentenceDataGridViewTextBoxColumn.DataPropertyName = "questionMainSentence";
            this.questionMainSentenceDataGridViewTextBoxColumn.HeaderText = "questionMainSentence";
            this.questionMainSentenceDataGridViewTextBoxColumn.Name = "questionMainSentenceDataGridViewTextBoxColumn";
            this.questionMainSentenceDataGridViewTextBoxColumn.Visible = false;
            // 
            // questionAnswerADataGridViewTextBoxColumn
            // 
            this.questionAnswerADataGridViewTextBoxColumn.DataPropertyName = "questionAnswerA";
            this.questionAnswerADataGridViewTextBoxColumn.HeaderText = "questionAnswerA";
            this.questionAnswerADataGridViewTextBoxColumn.Name = "questionAnswerADataGridViewTextBoxColumn";
            this.questionAnswerADataGridViewTextBoxColumn.Visible = false;
            // 
            // questionAnswerBDataGridViewTextBoxColumn
            // 
            this.questionAnswerBDataGridViewTextBoxColumn.DataPropertyName = "questionAnswerB";
            this.questionAnswerBDataGridViewTextBoxColumn.HeaderText = "questionAnswerB";
            this.questionAnswerBDataGridViewTextBoxColumn.Name = "questionAnswerBDataGridViewTextBoxColumn";
            this.questionAnswerBDataGridViewTextBoxColumn.Visible = false;
            // 
            // questionAnswerCDataGridViewTextBoxColumn
            // 
            this.questionAnswerCDataGridViewTextBoxColumn.DataPropertyName = "questionAnswerC";
            this.questionAnswerCDataGridViewTextBoxColumn.HeaderText = "questionAnswerC";
            this.questionAnswerCDataGridViewTextBoxColumn.Name = "questionAnswerCDataGridViewTextBoxColumn";
            this.questionAnswerCDataGridViewTextBoxColumn.Visible = false;
            // 
            // questionAnswerDDataGridViewTextBoxColumn
            // 
            this.questionAnswerDDataGridViewTextBoxColumn.DataPropertyName = "questionAnswerD";
            this.questionAnswerDDataGridViewTextBoxColumn.HeaderText = "questionAnswerD";
            this.questionAnswerDDataGridViewTextBoxColumn.Name = "questionAnswerDDataGridViewTextBoxColumn";
            this.questionAnswerDDataGridViewTextBoxColumn.Visible = false;
            // 
            // questionTrueAnswerDataGridViewTextBoxColumn
            // 
            this.questionTrueAnswerDataGridViewTextBoxColumn.DataPropertyName = "questionTrueAnswer";
            this.questionTrueAnswerDataGridViewTextBoxColumn.HeaderText = "questionTrueAnswer";
            this.questionTrueAnswerDataGridViewTextBoxColumn.Name = "questionTrueAnswerDataGridViewTextBoxColumn";
            this.questionTrueAnswerDataGridViewTextBoxColumn.Visible = false;
            // 
            // questionNumberOfCorrectDataGridViewTextBoxColumn
            // 
            this.questionNumberOfCorrectDataGridViewTextBoxColumn.DataPropertyName = "questionNumberOfCorrect";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.questionNumberOfCorrectDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.questionNumberOfCorrectDataGridViewTextBoxColumn.HeaderText = "Question Number Of Correct";
            this.questionNumberOfCorrectDataGridViewTextBoxColumn.Name = "questionNumberOfCorrectDataGridViewTextBoxColumn";
            this.questionNumberOfCorrectDataGridViewTextBoxColumn.Width = 215;
            // 
            // questionViewDataGridViewTextBoxColumn
            // 
            this.questionViewDataGridViewTextBoxColumn.DataPropertyName = "questionView";
            this.questionViewDataGridViewTextBoxColumn.HeaderText = "questionView";
            this.questionViewDataGridViewTextBoxColumn.Name = "questionViewDataGridViewTextBoxColumn";
            this.questionViewDataGridViewTextBoxColumn.Visible = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(1280, 853);
            this.ControlBox = false;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this._6SigmaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._6SigmaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.questionDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl dragControlReport;
        private Guna.UI2.WinForms.Guna2Elipse elipseReportPage;
        private _6SigmaDataSet2 _6SigmaDataSet2;
        private System.Windows.Forms.BindingSource sigmaDataSet2BindingSource;
        private _6SigmaDataSet3 _6SigmaDataSet3;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private _6SigmaDataSet3TableAdapters.questionsTableAdapter questionsTableAdapter;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView questionDataGrid;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quetionImagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionMainSentenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionAnswerADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionAnswerBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionAnswerCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionAnswerDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionTrueAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionNumberOfCorrectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionViewDataGridViewTextBoxColumn;
    }
}