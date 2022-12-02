namespace Laba8
{
    partial class AddStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameInputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupInputNUD = new System.Windows.Forms.NumericUpDown();
            this.AcceptNewStudentBtn = new System.Windows.Forms.Button();
            this.RadioBtn1 = new System.Windows.Forms.RadioButton();
            this.RadioBtn2 = new System.Windows.Forms.RadioButton();
            this.RadioBtn3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentNumberNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GroupInputNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentNumberNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО студента полностью";
            // 
            // NameInputTextBox
            // 
            this.NameInputTextBox.Location = new System.Drawing.Point(199, 22);
            this.NameInputTextBox.Name = "NameInputTextBox";
            this.NameInputTextBox.Size = new System.Drawing.Size(273, 22);
            this.NameInputTextBox.TabIndex = 1;
            this.NameInputTextBox.TextChanged += new System.EventHandler(this.NameInputTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер группы";
            // 
            // GroupInputNUD
            // 
            this.GroupInputNUD.BackColor = System.Drawing.SystemColors.Window;
            this.GroupInputNUD.Location = new System.Drawing.Point(119, 66);
            this.GroupInputNUD.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.GroupInputNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GroupInputNUD.Name = "GroupInputNUD";
            this.GroupInputNUD.ReadOnly = true;
            this.GroupInputNUD.Size = new System.Drawing.Size(41, 22);
            this.GroupInputNUD.TabIndex = 3;
            this.GroupInputNUD.TabStop = false;
            this.GroupInputNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AcceptNewStudentBtn
            // 
            this.AcceptNewStudentBtn.Enabled = false;
            this.AcceptNewStudentBtn.Location = new System.Drawing.Point(215, 151);
            this.AcceptNewStudentBtn.Name = "AcceptNewStudentBtn";
            this.AcceptNewStudentBtn.Size = new System.Drawing.Size(257, 67);
            this.AcceptNewStudentBtn.TabIndex = 4;
            this.AcceptNewStudentBtn.Text = "Подтвердить";
            this.AcceptNewStudentBtn.UseVisualStyleBackColor = true;
            this.AcceptNewStudentBtn.Click += new System.EventHandler(this.AcceptNewStudentBtn_Click);
            // 
            // RadioBtn1
            // 
            this.RadioBtn1.AutoSize = true;
            this.RadioBtn1.Location = new System.Drawing.Point(15, 127);
            this.RadioBtn1.Name = "RadioBtn1";
            this.RadioBtn1.Size = new System.Drawing.Size(139, 21);
            this.RadioBtn1.TabIndex = 5;
            this.RadioBtn1.TabStop = true;
            this.RadioBtn1.Text = "В начало списка";
            this.RadioBtn1.UseVisualStyleBackColor = true;
            // 
            // RadioBtn2
            // 
            this.RadioBtn2.AutoSize = true;
            this.RadioBtn2.Location = new System.Drawing.Point(15, 154);
            this.RadioBtn2.Name = "RadioBtn2";
            this.RadioBtn2.Size = new System.Drawing.Size(134, 21);
            this.RadioBtn2.TabIndex = 6;
            this.RadioBtn2.TabStop = true;
            this.RadioBtn2.Text = "В конец списка ";
            this.RadioBtn2.UseVisualStyleBackColor = true;
            // 
            // RadioBtn3
            // 
            this.RadioBtn3.AutoSize = true;
            this.RadioBtn3.Location = new System.Drawing.Point(15, 181);
            this.RadioBtn3.Name = "RadioBtn3";
            this.RadioBtn3.Size = new System.Drawing.Size(170, 21);
            this.RadioBtn3.TabIndex = 7;
            this.RadioBtn3.TabStop = true;
            this.RadioBtn3.Text = "С заданным номером";
            this.RadioBtn3.UseVisualStyleBackColor = true;
            this.RadioBtn3.CheckedChanged += new System.EventHandler(this.RadioBtn3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Способ добавления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите номер";
            this.label4.Visible = false;
            // 
            // StudentNumberNUD
            // 
            this.StudentNumberNUD.BackColor = System.Drawing.SystemColors.Window;
            this.StudentNumberNUD.Location = new System.Drawing.Point(126, 215);
            this.StudentNumberNUD.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.StudentNumberNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StudentNumberNUD.Name = "StudentNumberNUD";
            this.StudentNumberNUD.ReadOnly = true;
            this.StudentNumberNUD.Size = new System.Drawing.Size(41, 22);
            this.StudentNumberNUD.TabIndex = 10;
            this.StudentNumberNUD.TabStop = false;
            this.StudentNumberNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StudentNumberNUD.Visible = false;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 251);
            this.Controls.Add(this.StudentNumberNUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RadioBtn3);
            this.Controls.Add(this.RadioBtn2);
            this.Controls.Add(this.RadioBtn1);
            this.Controls.Add(this.AcceptNewStudentBtn);
            this.Controls.Add(this.GroupInputNUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameInputTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudentForm";
            this.Text = "Добавление студента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddStudentForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.GroupInputNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentNumberNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameInputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown GroupInputNUD;
        private System.Windows.Forms.Button AcceptNewStudentBtn;
        private System.Windows.Forms.RadioButton RadioBtn1;
        private System.Windows.Forms.RadioButton RadioBtn2;
        private System.Windows.Forms.RadioButton RadioBtn3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown StudentNumberNUD;
    }
}