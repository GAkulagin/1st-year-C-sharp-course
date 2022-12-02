namespace Laba8
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ShowGroupListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupNumberNUD = new System.Windows.Forms.NumericUpDown();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ShowMainListBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumberNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(350, 59);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(162, 54);
            this.AddStudentBtn.TabIndex = 0;
            this.AddStudentBtn.Text = "Добавить студента";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(12, 125);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(669, 318);
            this.OutputTextBox.TabIndex = 1;
            // 
            // ShowGroupListBtn
            // 
            this.ShowGroupListBtn.Location = new System.Drawing.Point(12, 59);
            this.ShowGroupListBtn.Name = "ShowGroupListBtn";
            this.ShowGroupListBtn.Size = new System.Drawing.Size(154, 54);
            this.ShowGroupListBtn.TabIndex = 2;
            this.ShowGroupListBtn.Text = "Показать список группы";
            this.ShowGroupListBtn.UseVisualStyleBackColor = true;
            this.ShowGroupListBtn.Click += new System.EventHandler(this.ShowGroupListBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Группа";
            // 
            // GroupNumberNUD
            // 
            this.GroupNumberNUD.BackColor = System.Drawing.SystemColors.Window;
            this.GroupNumberNUD.Location = new System.Drawing.Point(70, 27);
            this.GroupNumberNUD.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.GroupNumberNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GroupNumberNUD.Name = "GroupNumberNUD";
            this.GroupNumberNUD.ReadOnly = true;
            this.GroupNumberNUD.Size = new System.Drawing.Size(50, 22);
            this.GroupNumberNUD.TabIndex = 4;
            this.GroupNumberNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(527, 59);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(154, 54);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Поиск студента";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ShowMainListBtn
            // 
            this.ShowMainListBtn.Location = new System.Drawing.Point(181, 59);
            this.ShowMainListBtn.Name = "ShowMainListBtn";
            this.ShowMainListBtn.Size = new System.Drawing.Size(154, 54);
            this.ShowMainListBtn.TabIndex = 6;
            this.ShowMainListBtn.Text = "Показать список первокурсников";
            this.ShowMainListBtn.UseVisualStyleBackColor = true;
            this.ShowMainListBtn.Click += new System.EventHandler(this.ShowMainListBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.ShowMainListBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.GroupNumberNUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowGroupListBtn);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.AddStudentBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа № 8";
            ((System.ComponentModel.ISupportInitialize)(this.GroupNumberNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button ShowGroupListBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown GroupNumberNUD;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ShowMainListBtn;
    }
}

