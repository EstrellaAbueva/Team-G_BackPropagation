﻿namespace Team_G_BackPropagation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.train = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.epochs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.density = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.ComboBox();
            this.sex = new System.Windows.Forms.ComboBox();
            this.scholar = new System.Windows.Forms.ComboBox();
            this.study = new System.Windows.Forms.ComboBox();
            this.nonsci = new System.Windows.Forms.ComboBox();
            this.sci = new System.Windows.Forms.ComboBox();
            this.attendance = new System.Windows.Forms.ComboBox();
            this.mid1 = new System.Windows.Forms.ComboBox();
            this.mid2 = new System.Windows.Forms.ComboBox();
            this.notes = new System.Windows.Forms.ComboBox();
            this.listen = new System.Windows.Forms.ComboBox();
            this.interest = new System.Windows.Forms.ComboBox();
            this.grade = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // train
            // 
            this.train.Location = new System.Drawing.Point(527, 79);
            this.train.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(147, 49);
            this.train.TabIndex = 1;
            this.train.Text = "Train";
            this.train.UseVisualStyleBackColor = true;
            this.train.Click += new System.EventHandler(this.train_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(759, 639);
            this.test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(147, 49);
            this.test.TabIndex = 15;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // epochs
            // 
            this.epochs.Location = new System.Drawing.Point(293, 106);
            this.epochs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.epochs.Name = "epochs";
            this.epochs.Size = new System.Drawing.Size(216, 22);
            this.epochs.TabIndex = 0;
            this.epochs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student\'s Performance Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Epochs :";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(239, 654);
            this.output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(485, 75);
            this.output.TabIndex = 8;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 474);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Scholarship Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 508);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Study Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 677);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Grade Category";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(759, 695);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(147, 50);
            this.clear.TabIndex = 16;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(149, 537);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Reading Frequency (non-scientific books/journals)";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(149, 575);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 33);
            this.label7.TabIndex = 16;
            this.label7.Text = "Reading Frequency (scientific books/journals)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 615);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Attendance to Classes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(944, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseFileToolStripMenuItem
            // 
            this.chooseFileToolStripMenuItem.Name = "chooseFileToolStripMenuItem";
            this.chooseFileToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.chooseFileToolStripMenuItem.Text = "Choose File";
            this.chooseFileToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(468, 575);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 32);
            this.label11.TabIndex = 37;
            this.label11.Text = "Cumulative grade point average in the last semester ";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(468, 539);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 32);
            this.label12.TabIndex = 36;
            this.label12.Text = "Discussion improves my interest and success in the course";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(468, 508);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "Listening in classes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(469, 474);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "Taking notes in classes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(468, 439);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 16);
            this.label15.TabIndex = 33;
            this.label15.Text = "Preparation to midterm exams 2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(468, 409);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "Preparation to midterm exams 1";
            // 
            // density
            // 
            this.density.AutoSize = true;
            this.density.Location = new System.Drawing.Point(149, 409);
            this.density.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.density.Name = "density";
            this.density.Size = new System.Drawing.Size(32, 16);
            this.density.TabIndex = 31;
            this.density.Text = "Age";
            // 
            // age
            // 
            this.age.FormattingEnabled = true;
            this.age.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.age.Location = new System.Drawing.Point(351, 406);
            this.age.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(91, 24);
            this.age.TabIndex = 38;
            this.age.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "1",
            "2"});
            this.sex.Location = new System.Drawing.Point(351, 438);
            this.sex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(91, 24);
            this.sex.TabIndex = 39;
            // 
            // scholar
            // 
            this.scholar.FormattingEnabled = true;
            this.scholar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.scholar.Location = new System.Drawing.Point(351, 474);
            this.scholar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scholar.Name = "scholar";
            this.scholar.Size = new System.Drawing.Size(91, 24);
            this.scholar.TabIndex = 40;
            // 
            // study
            // 
            this.study.FormattingEnabled = true;
            this.study.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.study.Location = new System.Drawing.Point(351, 511);
            this.study.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.study.Name = "study";
            this.study.Size = new System.Drawing.Size(91, 24);
            this.study.TabIndex = 41;
            this.study.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // nonsci
            // 
            this.nonsci.FormattingEnabled = true;
            this.nonsci.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.nonsci.Location = new System.Drawing.Point(351, 545);
            this.nonsci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nonsci.Name = "nonsci";
            this.nonsci.Size = new System.Drawing.Size(91, 24);
            this.nonsci.TabIndex = 42;
            // 
            // sci
            // 
            this.sci.FormattingEnabled = true;
            this.sci.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.sci.Location = new System.Drawing.Point(351, 578);
            this.sci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sci.Name = "sci";
            this.sci.Size = new System.Drawing.Size(91, 24);
            this.sci.TabIndex = 43;
            // 
            // attendance
            // 
            this.attendance.FormattingEnabled = true;
            this.attendance.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.attendance.Location = new System.Drawing.Point(351, 612);
            this.attendance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attendance.Name = "attendance";
            this.attendance.Size = new System.Drawing.Size(91, 24);
            this.attendance.TabIndex = 44;
            // 
            // mid1
            // 
            this.mid1.FormattingEnabled = true;
            this.mid1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.mid1.Location = new System.Drawing.Point(715, 405);
            this.mid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mid1.Name = "mid1";
            this.mid1.Size = new System.Drawing.Size(91, 24);
            this.mid1.TabIndex = 45;
            // 
            // mid2
            // 
            this.mid2.FormattingEnabled = true;
            this.mid2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.mid2.Location = new System.Drawing.Point(715, 441);
            this.mid2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mid2.Name = "mid2";
            this.mid2.Size = new System.Drawing.Size(91, 24);
            this.mid2.TabIndex = 46;
            // 
            // notes
            // 
            this.notes.FormattingEnabled = true;
            this.notes.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.notes.Location = new System.Drawing.Point(715, 474);
            this.notes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(91, 24);
            this.notes.TabIndex = 47;
            // 
            // listen
            // 
            this.listen.FormattingEnabled = true;
            this.listen.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.listen.Location = new System.Drawing.Point(715, 508);
            this.listen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(91, 24);
            this.listen.TabIndex = 48;
            // 
            // interest
            // 
            this.interest.FormattingEnabled = true;
            this.interest.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.interest.Location = new System.Drawing.Point(715, 544);
            this.interest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.interest.Name = "interest";
            this.interest.Size = new System.Drawing.Size(91, 24);
            this.interest.TabIndex = 49;
            // 
            // grade
            // 
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.grade.Location = new System.Drawing.Point(715, 581);
            this.grade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(91, 24);
            this.grade.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(75, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(831, 254);
            this.label9.TabIndex = 51;
            this.label9.Text = resources.GetString("label9.Text");
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(944, 761);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.interest);
            this.Controls.Add(this.listen);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.mid2);
            this.Controls.Add(this.mid1);
            this.Controls.Add(this.attendance);
            this.Controls.Add(this.sci);
            this.Controls.Add(this.nonsci);
            this.Controls.Add(this.study);
            this.Controls.Add(this.scholar);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.density);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.epochs);
            this.Controls.Add(this.test);
            this.Controls.Add(this.train);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Team-G_BackPropagation";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button train;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.TextBox epochs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clear;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label density;
        private System.Windows.Forms.ComboBox age;
        private System.Windows.Forms.ComboBox scholar;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.ComboBox study;
        private System.Windows.Forms.ComboBox nonsci;
        private System.Windows.Forms.ComboBox mid1;
        private System.Windows.Forms.ComboBox attendance;
        private System.Windows.Forms.ComboBox sci;
        private System.Windows.Forms.ComboBox mid2;
        private System.Windows.Forms.ComboBox notes;
        private System.Windows.Forms.ComboBox listen;
        private System.Windows.Forms.ComboBox interest;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.Label label9;
    }
}

