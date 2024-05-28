namespace Lab5
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
            this.birthdayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.ListOfStudent = new System.Windows.Forms.ListView();
            this.labelListOfStudent = new System.Windows.Forms.Label();
            this.labelDateChoose = new System.Windows.Forms.Label();
            this.chooseDate = new System.Windows.Forms.DateTimePicker();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonShowStudentByDate = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // birthdayTimePicker
            // 
            this.birthdayTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.birthdayTimePicker.Location = new System.Drawing.Point(72, 111);
            this.birthdayTimePicker.Name = "birthdayTimePicker";
            this.birthdayTimePicker.Size = new System.Drawing.Size(164, 22);
            this.birthdayTimePicker.TabIndex = 0;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDate.Location = new System.Drawing.Point(40, 70);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(230, 20);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Оберіть дату народження";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSurname.Location = new System.Drawing.Point(68, 145);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(186, 20);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Прізівище студентки";
            this.labelSurname.Click += new System.EventHandler(this.labelSurname_Click);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(87, 178);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(141, 22);
            this.textBoxSurname.TabIndex = 3;
            // 
            // ListOfStudent
            // 
            this.ListOfStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ListOfStudent.HideSelection = false;
            this.ListOfStudent.Location = new System.Drawing.Point(312, 60);
            this.ListOfStudent.Name = "ListOfStudent";
            this.ListOfStudent.ShowItemToolTips = true;
            this.ListOfStudent.Size = new System.Drawing.Size(333, 268);
            this.ListOfStudent.TabIndex = 4;
            this.ListOfStudent.UseCompatibleStateImageBehavior = false;
            this.ListOfStudent.View = System.Windows.Forms.View.List;
            // 
            // labelListOfStudent
            // 
            this.labelListOfStudent.AutoSize = true;
            this.labelListOfStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelListOfStudent.Location = new System.Drawing.Point(396, 22);
            this.labelListOfStudent.Name = "labelListOfStudent";
            this.labelListOfStudent.Size = new System.Drawing.Size(162, 20);
            this.labelListOfStudent.TabIndex = 5;
            this.labelListOfStudent.Text = "Список студенток";
            // 
            // labelDateChoose
            // 
            this.labelDateChoose.AutoSize = true;
            this.labelDateChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDateChoose.Location = new System.Drawing.Point(303, 356);
            this.labelDateChoose.Name = "labelDateChoose";
            this.labelDateChoose.Size = new System.Drawing.Size(147, 20);
            this.labelDateChoose.TabIndex = 6;
            this.labelDateChoose.Text = "Пошук за датою";
            this.labelDateChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDateChoose.Click += new System.EventHandler(this.labelDateChoose_Click);
            // 
            // chooseDate
            // 
            this.chooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.chooseDate.Location = new System.Drawing.Point(297, 402);
            this.chooseDate.Name = "chooseDate";
            this.chooseDate.Size = new System.Drawing.Size(153, 22);
            this.chooseDate.TabIndex = 7;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddStudent.Location = new System.Drawing.Point(27, 217);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(112, 44);
            this.buttonAddStudent.TabIndex = 8;
            this.buttonAddStudent.Text = "Метод ділення";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.AddByDivision);
            // 
            // buttonShowStudentByDate
            // 
            this.buttonShowStudentByDate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonShowStudentByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowStudentByDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShowStudentByDate.Location = new System.Drawing.Point(311, 441);
            this.buttonShowStudentByDate.Name = "buttonShowStudentByDate";
            this.buttonShowStudentByDate.Size = new System.Drawing.Size(126, 33);
            this.buttonShowStudentByDate.TabIndex = 9;
            this.buttonShowStudentByDate.Text = "Показати";
            this.buttonShowStudentByDate.UseVisualStyleBackColor = false;
            this.buttonShowStudentByDate.Click += new System.EventHandler(this.showStudentByDate);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteStudent.Location = new System.Drawing.Point(102, 283);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(112, 44);
            this.buttonDeleteStudent.TabIndex = 10;
            this.buttonDeleteStudent.Text = "Видалити студентку";
            this.buttonDeleteStudent.UseVisualStyleBackColor = false;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.deleteStudent);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(175, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Метод множення";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addByMultiplication);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(297, 492);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(153, 204);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.Click += new System.EventHandler(this.showStudentByDate);
            // 
            // listView2
            // 
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(512, 492);
            this.listView2.Name = "listView2";
            this.listView2.ShowItemToolTips = true;
            this.listView2.Size = new System.Drawing.Size(153, 204);
            this.listView2.TabIndex = 16;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.Click += new System.EventHandler(this.showStudentByHash);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(526, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 33);
            this.button2.TabIndex = 15;
            this.button2.Text = "Показати";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.showStudentByHash);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(522, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Пошук за \r\nхеш-значенням";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(512, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(87, 573);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "Очистити";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.clearDateTable);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(728, 725);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDeleteStudent);
            this.Controls.Add(this.buttonShowStudentByDate);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.chooseDate);
            this.Controls.Add(this.labelDateChoose);
            this.Controls.Add(this.labelListOfStudent);
            this.Controls.Add(this.ListOfStudent);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.birthdayTimePicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker birthdayTimePicker;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.ListView ListOfStudent;
        private System.Windows.Forms.Label labelListOfStudent;
        private System.Windows.Forms.Label labelDateChoose;
        private System.Windows.Forms.DateTimePicker chooseDate;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonShowStudentByDate;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}

