﻿
namespace _6sigmaileProje
{
    partial class examPreparationModule
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
            this.elipseExPrepationModule = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControlExPrepationModule = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.rTextTitleForQuestion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rTextbxMainQuestion = new System.Windows.Forms.RichTextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.rTextboxImageFilePath = new System.Windows.Forms.RichTextBox();
            this.pathImage = new System.Windows.Forms.Label();
            this.btnChoose = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxModule = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialogModule = new System.Windows.Forms.OpenFileDialog();
            this.lblAnswerChoices = new System.Windows.Forms.Label();
            this.rTextbxAnwerA = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rTextbxAnwerB = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rTextbxAnwerC = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rTextbxAnwerD = new System.Windows.Forms.RichTextBox();
            this.btnAddQuestion = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.rTextbxTrueAnswer = new System.Windows.Forms.RichTextBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.rTextBoxSubject = new System.Windows.Forms.RichTextBox();
            this.lblQuestionSubject = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModule)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseExPrepationModule
            // 
            this.elipseExPrepationModule.BorderRadius = 10;
            this.elipseExPrepationModule.TargetControl = this;
            // 
            // dragControlExPrepationModule
            // 
            this.dragControlExPrepationModule.DockIndicatorTransparencyValue = 0.6D;
            this.dragControlExPrepationModule.TargetControl = this;
            this.dragControlExPrepationModule.UseTransparentDrag = true;
            // 
            // rTextTitleForQuestion
            // 
            this.rTextTitleForQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTextTitleForQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTextTitleForQuestion.Location = new System.Drawing.Point(192, 162);
            this.rTextTitleForQuestion.Name = "rTextTitleForQuestion";
            this.rTextTitleForQuestion.Size = new System.Drawing.Size(544, 125);
            this.rTextTitleForQuestion.TabIndex = 0;
            this.rTextTitleForQuestion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(226, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exam Preparation Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title For The Question";
            // 
            // rTextbxMainQuestion
            // 
            this.rTextbxMainQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTextbxMainQuestion.Location = new System.Drawing.Point(192, 585);
            this.rTextbxMainQuestion.Name = "rTextbxMainQuestion";
            this.rTextbxMainQuestion.Size = new System.Drawing.Size(544, 105);
            this.rTextbxMainQuestion.TabIndex = 3;
            this.rTextbxMainQuestion.Text = "";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.guna2Panel1.Controls.Add(this.lblQuestionSubject);
            this.guna2Panel1.Controls.Add(this.rTextBoxSubject);
            this.guna2Panel1.Controls.Add(this.rTextboxImageFilePath);
            this.guna2Panel1.Controls.Add(this.pathImage);
            this.guna2Panel1.Controls.Add(this.btnChoose);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.pictureBoxModule);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.rTextTitleForQuestion);
            this.guna2Panel1.Controls.Add(this.rTextbxMainQuestion);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(804, 853);
            this.guna2Panel1.TabIndex = 5;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // rTextboxImageFilePath
            // 
            this.rTextboxImageFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTextboxImageFilePath.Location = new System.Drawing.Point(192, 519);
            this.rTextboxImageFilePath.Name = "rTextboxImageFilePath";
            this.rTextboxImageFilePath.Size = new System.Drawing.Size(544, 50);
            this.rTextboxImageFilePath.TabIndex = 42;
            this.rTextboxImageFilePath.Text = "";
            // 
            // pathImage
            // 
            this.pathImage.AutoSize = true;
            this.pathImage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pathImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.pathImage.Location = new System.Drawing.Point(75, 535);
            this.pathImage.Name = "pathImage";
            this.pathImage.Size = new System.Drawing.Size(69, 20);
            this.pathImage.TabIndex = 17;
            this.pathImage.Text = "File Path";
            // 
            // btnChoose
            // 
            this.btnChoose.BorderColor = System.Drawing.Color.DimGray;
            this.btnChoose.BorderRadius = 8;
            this.btnChoose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(41)))));
            this.btnChoose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChoose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChoose.Location = new System.Drawing.Point(36, 400);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(130, 37);
            this.btnChoose.TabIndex = 16;
            this.btnChoose.Text = "Choose";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(44, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add Pictures";
            // 
            // pictureBoxModule
            // 
            this.pictureBoxModule.ImageRotate = 0F;
            this.pictureBoxModule.Location = new System.Drawing.Point(192, 303);
            this.pictureBoxModule.Name = "pictureBoxModule";
            this.pictureBoxModule.Size = new System.Drawing.Size(544, 200);
            this.pictureBoxModule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxModule.TabIndex = 5;
            this.pictureBoxModule.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(-3, 632);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Main Question Sentence";
            // 
            // openFileDialogModule
            // 
            this.openFileDialogModule.FileName = "openFileDialogModule";
            // 
            // lblAnswerChoices
            // 
            this.lblAnswerChoices.AutoSize = true;
            this.lblAnswerChoices.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnswerChoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.lblAnswerChoices.Location = new System.Drawing.Point(906, 138);
            this.lblAnswerChoices.Name = "lblAnswerChoices";
            this.lblAnswerChoices.Size = new System.Drawing.Size(134, 21);
            this.lblAnswerChoices.TabIndex = 6;
            this.lblAnswerChoices.Text = "Answer Choices";
            // 
            // rTextbxAnwerA
            // 
            this.rTextbxAnwerA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTextbxAnwerA.Location = new System.Drawing.Point(939, 178);
            this.rTextbxAnwerA.Name = "rTextbxAnwerA";
            this.rTextbxAnwerA.Size = new System.Drawing.Size(426, 71);
            this.rTextbxAnwerA.TabIndex = 7;
            this.rTextbxAnwerA.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(902, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "A-)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(902, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "B-)";
            // 
            // rTextbxAnwerB
            // 
            this.rTextbxAnwerB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTextbxAnwerB.Location = new System.Drawing.Point(939, 270);
            this.rTextbxAnwerB.Name = "rTextbxAnwerB";
            this.rTextbxAnwerB.Size = new System.Drawing.Size(426, 71);
            this.rTextbxAnwerB.TabIndex = 9;
            this.rTextbxAnwerB.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(902, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "C-)";
            // 
            // rTextbxAnwerC
            // 
            this.rTextbxAnwerC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTextbxAnwerC.Location = new System.Drawing.Point(939, 362);
            this.rTextbxAnwerC.Name = "rTextbxAnwerC";
            this.rTextbxAnwerC.Size = new System.Drawing.Size(426, 71);
            this.rTextbxAnwerC.TabIndex = 11;
            this.rTextbxAnwerC.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(902, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "D-)";
            // 
            // rTextbxAnwerD
            // 
            this.rTextbxAnwerD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTextbxAnwerD.Location = new System.Drawing.Point(939, 454);
            this.rTextbxAnwerD.Name = "rTextbxAnwerD";
            this.rTextbxAnwerD.Size = new System.Drawing.Size(426, 71);
            this.rTextbxAnwerD.TabIndex = 13;
            this.rTextbxAnwerD.Text = "";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BorderColor = System.Drawing.Color.White;
            this.btnAddQuestion.BorderRadius = 8;
            this.btnAddQuestion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddQuestion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddQuestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(41)))));
            this.btnAddQuestion.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnAddQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddQuestion.Location = new System.Drawing.Point(939, 667);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Padding = new System.Windows.Forms.Padding(10);
            this.btnAddQuestion.Size = new System.Drawing.Size(435, 48);
            this.btnAddQuestion.TabIndex = 15;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.label9.Location = new System.Drawing.Point(1060, 571);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "True Answer";
            // 
            // rTextbxTrueAnswer
            // 
            this.rTextbxTrueAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTextbxTrueAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.rTextbxTrueAnswer.Location = new System.Drawing.Point(1162, 551);
            this.rTextbxTrueAnswer.Name = "rTextbxTrueAnswer";
            this.rTextbxTrueAnswer.Size = new System.Drawing.Size(78, 46);
            this.rTextbxTrueAnswer.TabIndex = 17;
            this.rTextbxTrueAnswer.Text = "";
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 40;
            this.btnBack.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(41)))));
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1504, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 77);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // rTextBoxSubject
            // 
            this.rTextBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTextBoxSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTextBoxSubject.Location = new System.Drawing.Point(192, 83);
            this.rTextBoxSubject.Name = "rTextBoxSubject";
            this.rTextBoxSubject.Size = new System.Drawing.Size(544, 60);
            this.rTextBoxSubject.TabIndex = 43;
            this.rTextBoxSubject.Text = "";
            // 
            // lblQuestionSubject
            // 
            this.lblQuestionSubject.AutoSize = true;
            this.lblQuestionSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuestionSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.lblQuestionSubject.Location = new System.Drawing.Point(32, 101);
            this.lblQuestionSubject.Name = "lblQuestionSubject";
            this.lblQuestionSubject.Size = new System.Drawing.Size(143, 21);
            this.lblQuestionSubject.TabIndex = 44;
            this.lblQuestionSubject.Text = "Question Subject";
            // 
            // examPreparationModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(1608, 853);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rTextbxTrueAnswer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rTextbxAnwerD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rTextbxAnwerC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rTextbxAnwerB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rTextbxAnwerA);
            this.Controls.Add(this.lblAnswerChoices);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "examPreparationModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamPreparationModule";
            this.Load += new System.EventHandler(this.examPreparationModule_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseExPrepationModule;
        private Guna.UI2.WinForms.Guna2DragControl dragControlExPrepationModule;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxModule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTextTitleForQuestion;
        private System.Windows.Forms.RichTextBox rTextbxMainQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialogModule;
        private Guna.UI2.WinForms.Guna2Button btnAddQuestion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rTextbxAnwerD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rTextbxAnwerC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rTextbxAnwerB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rTextbxAnwerA;
        private System.Windows.Forms.Label lblAnswerChoices;
        private Guna.UI2.WinForms.Guna2Button btnChoose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label pathImage;
        private System.Windows.Forms.RichTextBox rTextbxTrueAnswer;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.RichTextBox rTextboxImageFilePath;
        private System.Windows.Forms.Label lblQuestionSubject;
        private System.Windows.Forms.RichTextBox rTextBoxSubject;
    }
}