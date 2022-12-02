namespace Laba8
{
    partial class SearchAndChangeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KeySearchBtn = new System.Windows.Forms.Button();
            this.NumberSearchBtn = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.EditEnabledBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.RewriteBtn = new System.Windows.Forms.Button();
            this.RewriteNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveChangesBtn = new System.Windows.Forms.Button();
            this.GroupNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по ключу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите имя/фамилию/отчество студента";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 80);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(286, 22);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.KeySearchTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Поиск по номеру";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введите номер студента из общего списка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Номер";
            // 
            // KeySearchBtn
            // 
            this.KeySearchBtn.Enabled = false;
            this.KeySearchBtn.Location = new System.Drawing.Point(15, 123);
            this.KeySearchBtn.Name = "KeySearchBtn";
            this.KeySearchBtn.Size = new System.Drawing.Size(154, 38);
            this.KeySearchBtn.TabIndex = 9;
            this.KeySearchBtn.Text = "Найти по ключу";
            this.KeySearchBtn.UseVisualStyleBackColor = true;
            this.KeySearchBtn.Click += new System.EventHandler(this.KeySearchBtn_Click);
            // 
            // NumberSearchBtn
            // 
            this.NumberSearchBtn.Location = new System.Drawing.Point(368, 123);
            this.NumberSearchBtn.Name = "NumberSearchBtn";
            this.NumberSearchBtn.Size = new System.Drawing.Size(154, 38);
            this.NumberSearchBtn.TabIndex = 10;
            this.NumberSearchBtn.Text = "Найти по номеру";
            this.NumberSearchBtn.UseVisualStyleBackColor = true;
            this.NumberSearchBtn.Click += new System.EventHandler(this.NumberSearchBtn_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OutputTextBox.Location = new System.Drawing.Point(15, 191);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(319, 249);
            this.OutputTextBox.TabIndex = 11;
            // 
            // EditEnabledBtn
            // 
            this.EditEnabledBtn.Location = new System.Drawing.Point(368, 191);
            this.EditEnabledBtn.Name = "EditEnabledBtn";
            this.EditEnabledBtn.Size = new System.Drawing.Size(154, 34);
            this.EditEnabledBtn.TabIndex = 12;
            this.EditEnabledBtn.Text = "Редактировать";
            this.EditEnabledBtn.UseVisualStyleBackColor = true;
            this.EditEnabledBtn.Click += new System.EventHandler(this.EditEnabledBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Location = new System.Drawing.Point(368, 403);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(154, 37);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Удалить запись";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // RewriteBtn
            // 
            this.RewriteBtn.Enabled = false;
            this.RewriteBtn.Location = new System.Drawing.Point(368, 250);
            this.RewriteBtn.Name = "RewriteBtn";
            this.RewriteBtn.Size = new System.Drawing.Size(154, 37);
            this.RewriteBtn.TabIndex = 14;
            this.RewriteBtn.Text = "Изменить запись";
            this.RewriteBtn.UseVisualStyleBackColor = true;
            this.RewriteBtn.Visible = false;
            this.RewriteBtn.Click += new System.EventHandler(this.RewriteBtn_Click);
            // 
            // RewriteNameTextBox
            // 
            this.RewriteNameTextBox.Location = new System.Drawing.Point(369, 303);
            this.RewriteNameTextBox.Name = "RewriteNameTextBox";
            this.RewriteNameTextBox.Size = new System.Drawing.Size(286, 22);
            this.RewriteNameTextBox.TabIndex = 15;
            this.RewriteNameTextBox.Visible = false;
            this.RewriteNameTextBox.TextChanged += new System.EventHandler(this.RewriteNameTextBox_TextChanged);
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.Enabled = false;
            this.SaveChangesBtn.Location = new System.Drawing.Point(502, 343);
            this.SaveChangesBtn.Name = "SaveChangesBtn";
            this.SaveChangesBtn.Size = new System.Drawing.Size(153, 43);
            this.SaveChangesBtn.TabIndex = 16;
            this.SaveChangesBtn.Text = "Сохранить изменения";
            this.SaveChangesBtn.UseVisualStyleBackColor = true;
            this.SaveChangesBtn.Visible = false;
            this.SaveChangesBtn.Click += new System.EventHandler(this.SaveChangesBtn_Click);
            // 
            // GroupNUD
            // 
            this.GroupNUD.Location = new System.Drawing.Point(422, 81);
            this.GroupNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GroupNUD.Name = "GroupNUD";
            this.GroupNUD.Size = new System.Drawing.Size(49, 22);
            this.GroupNUD.TabIndex = 17;
            this.GroupNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GroupNUD.ValueChanged += new System.EventHandler(this.GroupNUD_ValueChanged);
            // 
            // SearchAndChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 452);
            this.Controls.Add(this.GroupNUD);
            this.Controls.Add(this.SaveChangesBtn);
            this.Controls.Add(this.RewriteNameTextBox);
            this.Controls.Add(this.RewriteBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditEnabledBtn);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.NumberSearchBtn);
            this.Controls.Add(this.KeySearchBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchAndChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchAndChangeForm";
            ((System.ComponentModel.ISupportInitialize)(this.GroupNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button KeySearchBtn;
        private System.Windows.Forms.Button NumberSearchBtn;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button EditEnabledBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button RewriteBtn;
        private System.Windows.Forms.TextBox RewriteNameTextBox;
        private System.Windows.Forms.Button SaveChangesBtn;
        private System.Windows.Forms.NumericUpDown GroupNUD;
    }
}