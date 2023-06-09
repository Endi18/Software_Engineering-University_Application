﻿
namespace University_Application
{
    partial class Form_Professor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Professor));
            this.panel_Output = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button_Grades = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Students = new System.Windows.Forms.Button();
            this.button_HighestScore = new System.Windows.Forms.Button();
            this.button_LowestScore = new System.Windows.Forms.Button();
            this.button_Average = new System.Windows.Forms.Button();
            this.button_PassingStudents = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Output
            // 
            this.panel_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.panel_Output.Controls.Add(this.label2);
            this.panel_Output.Controls.Add(this.richTextBox1);
            this.panel_Output.Controls.Add(this.comboBox_Course);
            this.panel_Output.Controls.Add(this.buttonExit);
            this.panel_Output.Location = new System.Drawing.Point(215, 0);
            this.panel_Output.Name = "panel_Output";
            this.panel_Output.Size = new System.Drawing.Size(304, 355);
            this.panel_Output.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Professor";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(20, 83);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(269, 261);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // comboBox_Course
            // 
            this.comboBox_Course.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_Course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Course.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox_Course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.comboBox_Course.FormattingEnabled = true;
            this.comboBox_Course.Location = new System.Drawing.Point(78, 50);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(153, 25);
            this.comboBox_Course.TabIndex = 19;
            this.comboBox_Course.Text = "Select Course";
            this.comboBox_Course.SelectedIndexChanged += new System.EventHandler(this.comboBox_Course_SelectedIndexChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.Snow;
            this.buttonExit.Location = new System.Drawing.Point(261, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 40);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button_Grades
            // 
            this.button_Grades.BackColor = System.Drawing.Color.Transparent;
            this.button_Grades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Grades.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Grades.FlatAppearance.BorderSize = 0;
            this.button_Grades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Grades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Grades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Grades.Font = new System.Drawing.Font("Corbel", 12.5F, System.Drawing.FontStyle.Bold);
            this.button_Grades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.button_Grades.Location = new System.Drawing.Point(0, 50);
            this.button_Grades.Name = "button_Grades";
            this.button_Grades.Size = new System.Drawing.Size(152, 27);
            this.button_Grades.TabIndex = 1;
            this.button_Grades.Text = "1. Add grades";
            this.button_Grades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Grades.UseVisualStyleBackColor = false;
            this.button_Grades.Click += new System.EventHandler(this.button_Grades_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Professor";
            this.label1.Click += new System.EventHandler(this.button_FailingStudents_Click);
            // 
            // button_Students
            // 
            this.button_Students.BackColor = System.Drawing.Color.Transparent;
            this.button_Students.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Students.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Students.FlatAppearance.BorderSize = 0;
            this.button_Students.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Students.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Students.Font = new System.Drawing.Font("Corbel", 12.5F, System.Drawing.FontStyle.Bold);
            this.button_Students.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.button_Students.Location = new System.Drawing.Point(0, 83);
            this.button_Students.Name = "button_Students";
            this.button_Students.Size = new System.Drawing.Size(168, 29);
            this.button_Students.TabIndex = 14;
            this.button_Students.Text = "2. Show students";
            this.button_Students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Students.UseVisualStyleBackColor = false;
            this.button_Students.Click += new System.EventHandler(this.button_Students_Click);
            // 
            // button_HighestScore
            // 
            this.button_HighestScore.BackColor = System.Drawing.Color.Transparent;
            this.button_HighestScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_HighestScore.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_HighestScore.FlatAppearance.BorderSize = 0;
            this.button_HighestScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_HighestScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_HighestScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HighestScore.Font = new System.Drawing.Font("Corbel", 12.5F, System.Drawing.FontStyle.Bold);
            this.button_HighestScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.button_HighestScore.Location = new System.Drawing.Point(0, 192);
            this.button_HighestScore.Name = "button_HighestScore";
            this.button_HighestScore.Size = new System.Drawing.Size(199, 50);
            this.button_HighestScore.TabIndex = 15;
            this.button_HighestScore.Text = "5. Show student with highest score";
            this.button_HighestScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_HighestScore.UseVisualStyleBackColor = false;
            this.button_HighestScore.Click += new System.EventHandler(this.button_HighestScore_Click);
            // 
            // button_LowestScore
            // 
            this.button_LowestScore.BackColor = System.Drawing.Color.Transparent;
            this.button_LowestScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_LowestScore.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_LowestScore.FlatAppearance.BorderSize = 0;
            this.button_LowestScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_LowestScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_LowestScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LowestScore.Font = new System.Drawing.Font("Corbel", 12.5F, System.Drawing.FontStyle.Bold);
            this.button_LowestScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.button_LowestScore.Location = new System.Drawing.Point(0, 248);
            this.button_LowestScore.Name = "button_LowestScore";
            this.button_LowestScore.Size = new System.Drawing.Size(199, 52);
            this.button_LowestScore.TabIndex = 16;
            this.button_LowestScore.Text = "6. Show student with lowest score";
            this.button_LowestScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_LowestScore.UseVisualStyleBackColor = false;
            this.button_LowestScore.Click += new System.EventHandler(this.buttonLowestScore_Click);
            // 
            // button_Average
            // 
            this.button_Average.BackColor = System.Drawing.Color.Transparent;
            this.button_Average.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Average.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Average.FlatAppearance.BorderSize = 0;
            this.button_Average.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Average.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Average.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Average.Font = new System.Drawing.Font("Corbel", 12.5F, System.Drawing.FontStyle.Bold);
            this.button_Average.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.button_Average.Location = new System.Drawing.Point(0, 154);
            this.button_Average.Name = "button_Average";
            this.button_Average.Size = new System.Drawing.Size(199, 32);
            this.button_Average.TabIndex = 17;
            this.button_Average.Text = "4. Show course score average";
            this.button_Average.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Average.UseVisualStyleBackColor = false;
            this.button_Average.Click += new System.EventHandler(this.button_Average_Click);
            // 
            // button_PassingStudents
            // 
            this.button_PassingStudents.BackColor = System.Drawing.Color.Transparent;
            this.button_PassingStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_PassingStudents.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_PassingStudents.FlatAppearance.BorderSize = 0;
            this.button_PassingStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_PassingStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_PassingStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PassingStudents.Font = new System.Drawing.Font("Corbel", 12.5F, System.Drawing.FontStyle.Bold);
            this.button_PassingStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.button_PassingStudents.Location = new System.Drawing.Point(0, 118);
            this.button_PassingStudents.Name = "button_PassingStudents";
            this.button_PassingStudents.Size = new System.Drawing.Size(214, 30);
            this.button_PassingStudents.TabIndex = 18;
            this.button_PassingStudents.Text = "3. Show passing students";
            this.button_PassingStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_PassingStudents.UseCompatibleTextRendering = true;
            this.button_PassingStudents.UseVisualStyleBackColor = false;
            this.button_PassingStudents.Click += new System.EventHandler(this.button_PassingStudents_Click);
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.button_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Back.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.button_Back.ForeColor = System.Drawing.Color.Snow;
            this.button_Back.Location = new System.Drawing.Point(0, 0);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(40, 40);
            this.button_Back.TabIndex = 19;
            this.button_Back.Text = "<";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 12.5F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(87)))));
            this.button1.Location = new System.Drawing.Point(0, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "7. Show failing students";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(516, 355);
            this.Controls.Add(this.button_HighestScore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_PassingStudents);
            this.Controls.Add(this.button_Average);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_LowestScore);
            this.Controls.Add(this.button_Students);
            this.Controls.Add(this.button_Grades);
            this.Controls.Add(this.panel_Output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Professor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+.";
            this.Load += new System.EventHandler(this.Form_Professor_Load);
            this.panel_Output.ResumeLayout(false);
            this.panel_Output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Output;
        private System.Windows.Forms.Button button_Grades;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Students;
        private System.Windows.Forms.Button button_HighestScore;
        private System.Windows.Forms.Button button_LowestScore;
        private System.Windows.Forms.Button button_Average;
        private System.Windows.Forms.Button button_PassingStudents;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}