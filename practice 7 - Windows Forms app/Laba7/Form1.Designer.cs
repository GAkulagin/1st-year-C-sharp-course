namespace Laba7
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.LengthInputNUD = new System.Windows.Forms.NumericUpDown();
            this.CreateArrBtn = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ArrInputTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InputArrBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddInputNUD = new System.Windows.Forms.NumericUpDown();
            this.AddElementsBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.StringsNUD = new System.Windows.Forms.NumericUpDown();
            this.ColumnsNUD = new System.Windows.Forms.NumericUpDown();
            this.CreateMatrixBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MatrixInputTextBox = new System.Windows.Forms.TextBox();
            this.InputMatrixBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LastStrNUD = new System.Windows.Forms.NumericUpDown();
            this.FirstStrNUD = new System.Windows.Forms.NumericUpDown();
            this.DelStringsBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.JagArrLengthInputNUD = new System.Windows.Forms.NumericUpDown();
            this.CreateJagArrBtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.JagArrInputTextBox = new System.Windows.Forms.TextBox();
            this.InputJagArrBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.AddStrLengthNUD = new System.Windows.Forms.NumericUpDown();
            this.AddStrNumberNUD = new System.Windows.Forms.NumericUpDown();
            this.AddStringBtn = new System.Windows.Forms.Button();
            this.SaveFileBtn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.LengthInputNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddInputNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StringsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastStrNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstStrNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JagArrLengthInputNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStrLengthNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStrNumberNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Работа с одномерным массивом";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ResultTextBox.Location = new System.Drawing.Point(782, 12);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultTextBox.Size = new System.Drawing.Size(380, 700);
            this.ResultTextBox.TabIndex = 3;
            this.ResultTextBox.WordWrap = false;
            // 
            // LengthInputNUD
            // 
            this.LengthInputNUD.BackColor = System.Drawing.SystemColors.Window;
            this.LengthInputNUD.Location = new System.Drawing.Point(179, 119);
            this.LengthInputNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthInputNUD.Name = "LengthInputNUD";
            this.LengthInputNUD.ReadOnly = true;
            this.LengthInputNUD.Size = new System.Drawing.Size(47, 22);
            this.LengthInputNUD.TabIndex = 4;
            this.LengthInputNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateArrBtn
            // 
            this.CreateArrBtn.Location = new System.Drawing.Point(16, 152);
            this.CreateArrBtn.Name = "CreateArrBtn";
            this.CreateArrBtn.Size = new System.Drawing.Size(141, 33);
            this.CreateArrBtn.TabIndex = 5;
            this.CreateArrBtn.Text = "Создать";
            this.CreateArrBtn.UseVisualStyleBackColor = true;
            this.CreateArrBtn.Click += new System.EventHandler(this.CreateArrBtn_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(13, 121);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(160, 17);
            this.InfoLabel.TabIndex = 6;
            this.InfoLabel.Text = "Количество элементов";
            // 
            // ArrInputTextBox
            // 
            this.ArrInputTextBox.Location = new System.Drawing.Point(261, 116);
            this.ArrInputTextBox.Name = "ArrInputTextBox";
            this.ArrInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ArrInputTextBox.Size = new System.Drawing.Size(244, 22);
            this.ArrInputTextBox.TabIndex = 7;
            this.ArrInputTextBox.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Создать массив\r\nиз случайных элементов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ввести массив вручную\r\nВводите целые числа через пробел";
            // 
            // InputArrBtn
            // 
            this.InputArrBtn.Location = new System.Drawing.Point(261, 152);
            this.InputArrBtn.Name = "InputArrBtn";
            this.InputArrBtn.Size = new System.Drawing.Size(141, 33);
            this.InputArrBtn.TabIndex = 10;
            this.InputArrBtn.Text = "Ввести";
            this.InputArrBtn.UseVisualStyleBackColor = true;
            this.InputArrBtn.Click += new System.EventHandler(this.InputArrBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "Добавить элементы\r\nв начало массива";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Количество элементов";
            // 
            // AddInputNUD
            // 
            this.AddInputNUD.BackColor = System.Drawing.SystemColors.Window;
            this.AddInputNUD.Location = new System.Drawing.Point(701, 114);
            this.AddInputNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AddInputNUD.Name = "AddInputNUD";
            this.AddInputNUD.ReadOnly = true;
            this.AddInputNUD.Size = new System.Drawing.Size(47, 22);
            this.AddInputNUD.TabIndex = 13;
            this.AddInputNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddElementsBtn
            // 
            this.AddElementsBtn.Location = new System.Drawing.Point(538, 152);
            this.AddElementsBtn.Name = "AddElementsBtn";
            this.AddElementsBtn.Size = new System.Drawing.Size(141, 33);
            this.AddElementsBtn.TabIndex = 14;
            this.AddElementsBtn.Text = "Добавить";
            this.AddElementsBtn.UseVisualStyleBackColor = true;
            this.AddElementsBtn.Click += new System.EventHandler(this.AddElementsBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Работа с двумерным массивом";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 34);
            this.label8.TabIndex = 16;
            this.label8.Text = "Создать массив\r\nиз случайных элементов";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Количество столбцов";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Количество строк";
            // 
            // StringsNUD
            // 
            this.StringsNUD.BackColor = System.Drawing.SystemColors.Window;
            this.StringsNUD.Location = new System.Drawing.Point(170, 338);
            this.StringsNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StringsNUD.Name = "StringsNUD";
            this.StringsNUD.ReadOnly = true;
            this.StringsNUD.Size = new System.Drawing.Size(47, 22);
            this.StringsNUD.TabIndex = 19;
            this.StringsNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ColumnsNUD
            // 
            this.ColumnsNUD.BackColor = System.Drawing.SystemColors.Window;
            this.ColumnsNUD.Location = new System.Drawing.Point(170, 389);
            this.ColumnsNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ColumnsNUD.Name = "ColumnsNUD";
            this.ColumnsNUD.ReadOnly = true;
            this.ColumnsNUD.Size = new System.Drawing.Size(47, 22);
            this.ColumnsNUD.TabIndex = 20;
            this.ColumnsNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateMatrixBtn
            // 
            this.CreateMatrixBtn.Location = new System.Drawing.Point(16, 444);
            this.CreateMatrixBtn.Name = "CreateMatrixBtn";
            this.CreateMatrixBtn.Size = new System.Drawing.Size(141, 33);
            this.CreateMatrixBtn.TabIndex = 21;
            this.CreateMatrixBtn.Text = "Создать";
            this.CreateMatrixBtn.UseVisualStyleBackColor = true;
            this.CreateMatrixBtn.Click += new System.EventHandler(this.CreateMatrixBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 34);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ввести массив вручную\r\nВводите целые числа через пробел";
            // 
            // MatrixInputTextBox
            // 
            this.MatrixInputTextBox.Location = new System.Drawing.Point(261, 310);
            this.MatrixInputTextBox.Multiline = true;
            this.MatrixInputTextBox.Name = "MatrixInputTextBox";
            this.MatrixInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MatrixInputTextBox.Size = new System.Drawing.Size(244, 118);
            this.MatrixInputTextBox.TabIndex = 23;
            this.MatrixInputTextBox.WordWrap = false;
            // 
            // InputMatrixBtn
            // 
            this.InputMatrixBtn.Location = new System.Drawing.Point(261, 444);
            this.InputMatrixBtn.Name = "InputMatrixBtn";
            this.InputMatrixBtn.Size = new System.Drawing.Size(141, 33);
            this.InputMatrixBtn.TabIndex = 24;
            this.InputMatrixBtn.Text = "Ввести";
            this.InputMatrixBtn.UseVisualStyleBackColor = true;
            this.InputMatrixBtn.Click += new System.EventHandler(this.InputMatrixBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(535, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Удалить строки";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(532, 391);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Конечная строка";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(535, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Начальная строка";
            // 
            // LastStrNUD
            // 
            this.LastStrNUD.BackColor = System.Drawing.SystemColors.Window;
            this.LastStrNUD.Location = new System.Drawing.Point(701, 389);
            this.LastStrNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LastStrNUD.Name = "LastStrNUD";
            this.LastStrNUD.ReadOnly = true;
            this.LastStrNUD.Size = new System.Drawing.Size(47, 22);
            this.LastStrNUD.TabIndex = 28;
            this.LastStrNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LastStrNUD.ValueChanged += new System.EventHandler(this.LastStrNUD_ValueChanged);
            // 
            // FirstStrNUD
            // 
            this.FirstStrNUD.BackColor = System.Drawing.SystemColors.Window;
            this.FirstStrNUD.Location = new System.Drawing.Point(701, 338);
            this.FirstStrNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FirstStrNUD.Name = "FirstStrNUD";
            this.FirstStrNUD.ReadOnly = true;
            this.FirstStrNUD.Size = new System.Drawing.Size(47, 22);
            this.FirstStrNUD.TabIndex = 29;
            this.FirstStrNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FirstStrNUD.ValueChanged += new System.EventHandler(this.FirstStrNUD_ValueChanged);
            // 
            // DelStringsBtn
            // 
            this.DelStringsBtn.Location = new System.Drawing.Point(535, 444);
            this.DelStringsBtn.Name = "DelStringsBtn";
            this.DelStringsBtn.Size = new System.Drawing.Size(141, 33);
            this.DelStringsBtn.TabIndex = 30;
            this.DelStringsBtn.Text = "Удалить";
            this.DelStringsBtn.UseVisualStyleBackColor = true;
            this.DelStringsBtn.Click += new System.EventHandler(this.DelStringsBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(247, 530);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(272, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "Работа с рваным массивом";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 574);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 34);
            this.label15.TabIndex = 32;
            this.label15.Text = "Создать массив\r\nиз случайных элементов";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 671);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Количество строк";
            // 
            // JagArrLengthInputNUD
            // 
            this.JagArrLengthInputNUD.BackColor = System.Drawing.SystemColors.Window;
            this.JagArrLengthInputNUD.Location = new System.Drawing.Point(170, 666);
            this.JagArrLengthInputNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.JagArrLengthInputNUD.Name = "JagArrLengthInputNUD";
            this.JagArrLengthInputNUD.ReadOnly = true;
            this.JagArrLengthInputNUD.Size = new System.Drawing.Size(47, 22);
            this.JagArrLengthInputNUD.TabIndex = 36;
            this.JagArrLengthInputNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateJagArrBtn
            // 
            this.CreateJagArrBtn.Location = new System.Drawing.Point(16, 746);
            this.CreateJagArrBtn.Name = "CreateJagArrBtn";
            this.CreateJagArrBtn.Size = new System.Drawing.Size(141, 33);
            this.CreateJagArrBtn.TabIndex = 37;
            this.CreateJagArrBtn.Text = "Создать";
            this.CreateJagArrBtn.UseVisualStyleBackColor = true;
            this.CreateJagArrBtn.Click += new System.EventHandler(this.CreateJagArrBtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(258, 574);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(247, 34);
            this.label17.TabIndex = 38;
            this.label17.Text = "Ввести массив вручную\r\nВводите целые числа через пробел";
            // 
            // JagArrInputTextBox
            // 
            this.JagArrInputTextBox.Location = new System.Drawing.Point(261, 611);
            this.JagArrInputTextBox.Multiline = true;
            this.JagArrInputTextBox.Name = "JagArrInputTextBox";
            this.JagArrInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.JagArrInputTextBox.Size = new System.Drawing.Size(244, 118);
            this.JagArrInputTextBox.TabIndex = 39;
            this.JagArrInputTextBox.WordWrap = false;
            // 
            // InputJagArrBtn
            // 
            this.InputJagArrBtn.Location = new System.Drawing.Point(261, 746);
            this.InputJagArrBtn.Name = "InputJagArrBtn";
            this.InputJagArrBtn.Size = new System.Drawing.Size(141, 33);
            this.InputJagArrBtn.TabIndex = 40;
            this.InputJagArrBtn.Text = "Ввести";
            this.InputJagArrBtn.UseVisualStyleBackColor = true;
            this.InputJagArrBtn.Click += new System.EventHandler(this.InputJagArrBtn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(535, 574);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 17);
            this.label18.TabIndex = 41;
            this.label18.Text = "Добавить строку";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(532, 692);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 17);
            this.label19.TabIndex = 42;
            this.label19.Text = "Длина строки";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(532, 636);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 17);
            this.label20.TabIndex = 43;
            this.label20.Text = "Номер строки";
            // 
            // AddStrLengthNUD
            // 
            this.AddStrLengthNUD.BackColor = System.Drawing.SystemColors.Window;
            this.AddStrLengthNUD.Location = new System.Drawing.Point(701, 690);
            this.AddStrLengthNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AddStrLengthNUD.Name = "AddStrLengthNUD";
            this.AddStrLengthNUD.ReadOnly = true;
            this.AddStrLengthNUD.Size = new System.Drawing.Size(47, 22);
            this.AddStrLengthNUD.TabIndex = 44;
            this.AddStrLengthNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddStrNumberNUD
            // 
            this.AddStrNumberNUD.BackColor = System.Drawing.SystemColors.Window;
            this.AddStrNumberNUD.Location = new System.Drawing.Point(701, 634);
            this.AddStrNumberNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AddStrNumberNUD.Name = "AddStrNumberNUD";
            this.AddStrNumberNUD.ReadOnly = true;
            this.AddStrNumberNUD.Size = new System.Drawing.Size(47, 22);
            this.AddStrNumberNUD.TabIndex = 45;
            this.AddStrNumberNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddStringBtn
            // 
            this.AddStringBtn.Location = new System.Drawing.Point(535, 746);
            this.AddStringBtn.Name = "AddStringBtn";
            this.AddStringBtn.Size = new System.Drawing.Size(141, 33);
            this.AddStringBtn.TabIndex = 46;
            this.AddStringBtn.Text = "Добавить";
            this.AddStringBtn.UseVisualStyleBackColor = true;
            this.AddStringBtn.Click += new System.EventHandler(this.AddStringBtn_Click);
            // 
            // SaveFileBtn
            // 
            this.SaveFileBtn.Location = new System.Drawing.Point(782, 746);
            this.SaveFileBtn.Name = "SaveFileBtn";
            this.SaveFileBtn.Size = new System.Drawing.Size(141, 33);
            this.SaveFileBtn.TabIndex = 47;
            this.SaveFileBtn.Text = "Сохранить в файл";
            this.SaveFileBtn.UseVisualStyleBackColor = true;
            this.SaveFileBtn.Click += new System.EventHandler(this.SaveFileBtn_Click);
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(1021, 746);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(141, 33);
            this.OpenFileBtn.TabIndex = 48;
            this.OpenFileBtn.Text = "Открыть файл";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 791);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.SaveFileBtn);
            this.Controls.Add(this.AddStringBtn);
            this.Controls.Add(this.AddStrNumberNUD);
            this.Controls.Add(this.AddStrLengthNUD);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.InputJagArrBtn);
            this.Controls.Add(this.JagArrInputTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CreateJagArrBtn);
            this.Controls.Add(this.JagArrLengthInputNUD);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DelStringsBtn);
            this.Controls.Add(this.FirstStrNUD);
            this.Controls.Add(this.LastStrNUD);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.InputMatrixBtn);
            this.Controls.Add(this.MatrixInputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateMatrixBtn);
            this.Controls.Add(this.ColumnsNUD);
            this.Controls.Add(this.StringsNUD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddElementsBtn);
            this.Controls.Add(this.AddInputNUD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InputArrBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ArrInputTextBox);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.CreateArrBtn);
            this.Controls.Add(this.LengthInputNUD);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №7";
            ((System.ComponentModel.ISupportInitialize)(this.LengthInputNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddInputNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StringsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastStrNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstStrNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JagArrLengthInputNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStrLengthNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStrNumberNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.NumericUpDown LengthInputNUD;
        private System.Windows.Forms.Button CreateArrBtn;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox ArrInputTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button InputArrBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown AddInputNUD;
        private System.Windows.Forms.Button AddElementsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown StringsNUD;
        private System.Windows.Forms.NumericUpDown ColumnsNUD;
        private System.Windows.Forms.Button CreateMatrixBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MatrixInputTextBox;
        private System.Windows.Forms.Button InputMatrixBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown LastStrNUD;
        private System.Windows.Forms.NumericUpDown FirstStrNUD;
        private System.Windows.Forms.Button DelStringsBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown JagArrLengthInputNUD;
        private System.Windows.Forms.Button CreateJagArrBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox JagArrInputTextBox;
        private System.Windows.Forms.Button InputJagArrBtn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown AddStrLengthNUD;
        private System.Windows.Forms.NumericUpDown AddStrNumberNUD;
        private System.Windows.Forms.Button AddStringBtn;
        private System.Windows.Forms.Button SaveFileBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

