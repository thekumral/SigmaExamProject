
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
            this.dragControlReport = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.elipseReportPage = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this._6SigmaDataSet2 = new _6sigmaileProje._6SigmaDataSet2();
            this.sigmaDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._6SigmaDataSet3 = new _6sigmaileProje._6SigmaDataSet3();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsTableAdapter = new _6sigmaileProje._6SigmaDataSet3TableAdapters.questionsTableAdapter();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.questionDataGrid = new System.Windows.Forms.DataGridView();
            this.questionViewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionNumberOfCorrectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTrueAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionAnswerDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionAnswerCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionAnswerBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionAnswerADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionMainSentenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quetionImagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._6SigmaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._6SigmaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionDataGrid)).BeginInit();
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
            this.questionDataGrid.Location = new System.Drawing.Point(0, 0);
            this.questionDataGrid.Name = "questionDataGrid";
            this.questionDataGrid.Size = new System.Drawing.Size(437, 853);
            this.questionDataGrid.TabIndex = 0;
            this.questionDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // questionViewDataGridViewTextBoxColumn
            // 
            this.questionViewDataGridViewTextBoxColumn.DataPropertyName = "questionView";
            this.questionViewDataGridViewTextBoxColumn.HeaderText = "questionView";
            this.questionViewDataGridViewTextBoxColumn.Name = "questionViewDataGridViewTextBoxColumn";
            // 
            // questionNumberOfCorrectDataGridViewTextBoxColumn
            // 
            this.questionNumberOfCorrectDataGridViewTextBoxColumn.DataPropertyName = "questionNumberOfCorrect";
            this.questionNumberOfCorrectDataGridViewTextBoxColumn.HeaderText = "Question Number Of Correct";
            this.questionNumberOfCorrectDataGridViewTextBoxColumn.Name = "questionNumberOfCorrectDataGridViewTextBoxColumn";
            // 
            // questionTrueAnswerDataGridViewTextBoxColumn
            // 
            this.questionTrueAnswerDataGridViewTextBoxColumn.DataPropertyName = "questionTrueAnswer";
            this.questionTrueAnswerDataGridViewTextBoxColumn.HeaderText = "questionTrueAnswer";
            this.questionTrueAnswerDataGridViewTextBoxColumn.Name = "questionTrueAnswerDataGridViewTextBoxColumn";
            // 
            // questionAnswerDDataGridViewTextBoxColumn
            // 
            this.questionAnswerDDataGridViewTextBoxColumn.DataPropertyName = "questionAnswerD";
            this.questionAnswerDDataGridViewTextBoxColumn.HeaderText = "questionAnswerD";
            this.questionAnswerDDataGridViewTextBoxColumn.Name = "questionAnswerDDataGridViewTextBoxColumn";
            // 
            // questionAnswerCDataGridViewTextBoxColumn
            // 
            this.questionAnswerCDataGridViewTextBoxColumn.DataPropertyName = "questionAnswerC";
            this.questionAnswerCDataGridViewTextBoxColumn.HeaderText = "questionAnswerC";
            this.questionAnswerCDataGridViewTextBoxColumn.Name = "questionAnswerCDataGridViewTextBoxColumn";
            // 
            // questionAnswerBDataGridViewTextBoxColumn
            // 
            this.questionAnswerBDataGridViewTextBoxColumn.DataPropertyName = "questionAnswerB";
            this.questionAnswerBDataGridViewTextBoxColumn.HeaderText = "questionAnswerB";
            this.questionAnswerBDataGridViewTextBoxColumn.Name = "questionAnswerBDataGridViewTextBoxColumn";
            // 
            // questionAnswerADataGridViewTextBoxColumn
            // 
            this.questionAnswerADataGridViewTextBoxColumn.DataPropertyName = "questionAnswerA";
            this.questionAnswerADataGridViewTextBoxColumn.HeaderText = "questionAnswerA";
            this.questionAnswerADataGridViewTextBoxColumn.Name = "questionAnswerADataGridViewTextBoxColumn";
            // 
            // questionMainSentenceDataGridViewTextBoxColumn
            // 
            this.questionMainSentenceDataGridViewTextBoxColumn.DataPropertyName = "questionMainSentence";
            this.questionMainSentenceDataGridViewTextBoxColumn.HeaderText = "questionMainSentence";
            this.questionMainSentenceDataGridViewTextBoxColumn.Name = "questionMainSentenceDataGridViewTextBoxColumn";
            // 
            // quetionImagePathDataGridViewTextBoxColumn
            // 
            this.quetionImagePathDataGridViewTextBoxColumn.DataPropertyName = "quetionImagePath";
            this.quetionImagePathDataGridViewTextBoxColumn.HeaderText = "quetionImagePath";
            this.quetionImagePathDataGridViewTextBoxColumn.Name = "quetionImagePathDataGridViewTextBoxColumn";
            // 
            // questionTitleDataGridViewTextBoxColumn
            // 
            this.questionTitleDataGridViewTextBoxColumn.DataPropertyName = "questionTitle";
            this.questionTitleDataGridViewTextBoxColumn.HeaderText = "questionTitle";
            this.questionTitleDataGridViewTextBoxColumn.Name = "questionTitleDataGridViewTextBoxColumn";
            // 
            // questionIDDataGridViewTextBoxColumn
            // 
            this.questionIDDataGridViewTextBoxColumn.DataPropertyName = "questionID";
            this.questionIDDataGridViewTextBoxColumn.HeaderText = "Question ID";
            this.questionIDDataGridViewTextBoxColumn.Name = "questionIDDataGridViewTextBoxColumn";
            this.questionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 853);
            this.ControlBox = false;
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