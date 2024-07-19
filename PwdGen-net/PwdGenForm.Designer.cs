namespace VX.PwdGen;

partial class PwdGenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PwdGenForm));
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_generate = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.cb_upperRussian = new System.Windows.Forms.CheckBox();
            this.cb_lowerEnglish = new System.Windows.Forms.CheckBox();
            this.cb_numbers = new System.Windows.Forms.CheckBox();
            this.cb_upperEnglish = new System.Windows.Forms.CheckBox();
            this.cb_lowerRussian = new System.Windows.Forms.CheckBox();
            this.cb_chars = new System.Windows.Forms.CheckBox();
            this.nud_length = new System.Windows.Forms.NumericUpDown();
            this.pb_length = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_length)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.Location = new System.Drawing.Point(12, 12);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_password.Size = new System.Drawing.Size(416, 35);
            this.tb_password.TabIndex = 0;
            // 
            // bt_generate
            // 
            this.bt_generate.Location = new System.Drawing.Point(434, 10);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(91, 23);
            this.bt_generate.TabIndex = 1;
            this.bt_generate.Text = "Генерировать";
            this.bt_generate.UseVisualStyleBackColor = true;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(434, 39);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(91, 23);
            this.bt_save.TabIndex = 2;
            this.bt_save.Text = "Сохранить";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(434, 68);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(91, 23);
            this.bt_exit.TabIndex = 3;
            this.bt_exit.Text = "Выход";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // cb_upperRussian
            // 
            this.cb_upperRussian.AutoSize = true;
            this.cb_upperRussian.Location = new System.Drawing.Point(12, 53);
            this.cb_upperRussian.Name = "cb_upperRussian";
            this.cb_upperRussian.Size = new System.Drawing.Size(160, 17);
            this.cb_upperRussian.TabIndex = 4;
            this.cb_upperRussian.Text = "Заглавные русские буквы";
            this.cb_upperRussian.UseVisualStyleBackColor = true;
            this.cb_upperRussian.CheckedChanged += new System.EventHandler(this.cb_mode_CheckedChanged);
            // 
            // cb_lowerEnglish
            // 
            this.cb_lowerEnglish.AutoSize = true;
            this.cb_lowerEnglish.Checked = true;
            this.cb_lowerEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_lowerEnglish.Location = new System.Drawing.Point(178, 53);
            this.cb_lowerEnglish.Name = "cb_lowerEnglish";
            this.cb_lowerEnglish.Size = new System.Drawing.Size(171, 17);
            this.cb_lowerEnglish.TabIndex = 5;
            this.cb_lowerEnglish.Text = "Строчные английские буквы";
            this.cb_lowerEnglish.UseVisualStyleBackColor = true;
            this.cb_lowerEnglish.CheckedChanged += new System.EventHandler(this.cb_mode_CheckedChanged);
            // 
            // cb_numbers
            // 
            this.cb_numbers.AutoSize = true;
            this.cb_numbers.Checked = true;
            this.cb_numbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_numbers.Location = new System.Drawing.Point(355, 53);
            this.cb_numbers.Name = "cb_numbers";
            this.cb_numbers.Size = new System.Drawing.Size(62, 17);
            this.cb_numbers.TabIndex = 6;
            this.cb_numbers.Text = "Цифры";
            this.cb_numbers.UseVisualStyleBackColor = true;
            this.cb_numbers.CheckedChanged += new System.EventHandler(this.cb_mode_CheckedChanged);
            // 
            // cb_upperEnglish
            // 
            this.cb_upperEnglish.AutoSize = true;
            this.cb_upperEnglish.Location = new System.Drawing.Point(12, 72);
            this.cb_upperEnglish.Name = "cb_upperEnglish";
            this.cb_upperEnglish.Size = new System.Drawing.Size(178, 17);
            this.cb_upperEnglish.TabIndex = 7;
            this.cb_upperEnglish.Text = "Заглавные английские буквы";
            this.cb_upperEnglish.UseVisualStyleBackColor = true;
            this.cb_upperEnglish.CheckedChanged += new System.EventHandler(this.cb_mode_CheckedChanged);
            // 
            // cb_lowerRussian
            // 
            this.cb_lowerRussian.AutoSize = true;
            this.cb_lowerRussian.Checked = true;
            this.cb_lowerRussian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_lowerRussian.Location = new System.Drawing.Point(196, 72);
            this.cb_lowerRussian.Name = "cb_lowerRussian";
            this.cb_lowerRussian.Size = new System.Drawing.Size(153, 17);
            this.cb_lowerRussian.TabIndex = 8;
            this.cb_lowerRussian.Text = "Строчные русские буквы";
            this.cb_lowerRussian.UseVisualStyleBackColor = true;
            this.cb_lowerRussian.CheckedChanged += new System.EventHandler(this.cb_mode_CheckedChanged);
            // 
            // cb_chars
            // 
            this.cb_chars.AutoSize = true;
            this.cb_chars.Location = new System.Drawing.Point(355, 72);
            this.cb_chars.Name = "cb_chars";
            this.cb_chars.Size = new System.Drawing.Size(73, 17);
            this.cb_chars.TabIndex = 9;
            this.cb_chars.Text = "Символы";
            this.cb_chars.UseVisualStyleBackColor = true;
            this.cb_chars.CheckedChanged += new System.EventHandler(this.cb_mode_CheckedChanged);
            // 
            // nud_length
            // 
            this.nud_length.Location = new System.Drawing.Point(107, 97);
            this.nud_length.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_length.Name = "nud_length";
            this.nud_length.Size = new System.Drawing.Size(43, 20);
            this.nud_length.TabIndex = 10;
            this.nud_length.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nud_length.ValueChanged += new System.EventHandler(this.nud_length_ValueChanged);
            // 
            // pb_length
            // 
            this.pb_length.Location = new System.Drawing.Point(156, 97);
            this.pb_length.MarqueeAnimationSpeed = 0;
            this.pb_length.Maximum = 370;
            this.pb_length.Minimum = 1;
            this.pb_length.Name = "pb_length";
            this.pb_length.Size = new System.Drawing.Size(369, 20);
            this.pb_length.Step = 1;
            this.pb_length.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_length.TabIndex = 11;
            this.pb_length.Value = 9;
            this.pb_length.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_length_MouseClick);
            this.pb_length.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_length_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Длинна пароля:";
            // 
            // PwdGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 129);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_length);
            this.Controls.Add(this.nud_length);
            this.Controls.Add(this.cb_chars);
            this.Controls.Add(this.cb_lowerRussian);
            this.Controls.Add(this.cb_upperEnglish);
            this.Controls.Add(this.cb_numbers);
            this.Controls.Add(this.cb_lowerEnglish);
            this.Controls.Add(this.cb_upperRussian);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_generate);
            this.Controls.Add(this.tb_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PwdGenForm";
            this.Text = "Генератор паролей";
            ((System.ComponentModel.ISupportInitialize)(this.nud_length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bt_generate;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.CheckBox cb_upperRussian;
        private System.Windows.Forms.CheckBox cb_lowerEnglish;
        private System.Windows.Forms.CheckBox cb_numbers;
        private System.Windows.Forms.CheckBox cb_upperEnglish;
        private System.Windows.Forms.CheckBox cb_lowerRussian;
        private System.Windows.Forms.CheckBox cb_chars;
        private System.Windows.Forms.NumericUpDown nud_length;
        private System.Windows.Forms.ProgressBar pb_length;
        private System.Windows.Forms.Label label1;
    }pwdgen generator;

    public PwdGenForm()
    {
        InitializeComponent();
        generator = new pwdgen();
    }

    private void bt_generate_Click(object sender, EventArgs e) => tb_password.Text = generator.Generate((int)nud_length.Value);

    private void bt_save_Click(object sender, EventArgs e)
    {
        if ("" == tb_password.Text)
        {
            MessageBox.Show("Нечего сохранять!");
            return;
        }
        var dialog = new SaveFileDialog();
        if (dialog.ShowDialog() != DialogResult.OK) return;
        using (var sw = new StreamWriter(dialog.FileName))
            sw.WriteLine($"{tb_password.Text}\t{DateTime.Now}");
    }

    private void bt_exit_Click(object sender, EventArgs e) => Close();

    private void cb_mode_CheckedChanged(object sender, EventArgs e)
    {
        var cb = sender as CheckBox;
        pwdgenModes flag = 0;
        if (cb == cb_upperRussian) flag = pwdgenModes.UpperRussian;
        if (cb == cb_lowerRussian) flag = pwdgenModes.LowerRussian;
        if (cb == cb_upperEnglish) flag = pwdgenModes.UpperEnglish;
        if (cb == cb_lowerEnglish) flag = pwdgenModes.LowerEnglish;
        if (cb == cb_numbers) flag = pwdgenModes.Numbers;
        if (cb == cb_chars) flag = pwdgenModes.Chars;
        var mode = generator.mode;
        mode.BoolFlag(flag, cb.Checked);
        generator.mode = mode;
    }

    void setLength(int value)
    {
        if (value > nud_length.Maximum) value = (int)nud_length.Maximum;
        if (value < nud_length.Minimum) value = (int)nud_length.Minimum;

        nud_length.ValueChanged -= nud_length_ValueChanged;
        nud_length.Value = value;
        nud_length.ValueChanged += nud_length_ValueChanged;

        if (value > pb_length.Maximum) value = pb_length.Maximum;
        if (value < pb_length.Minimum) value = pb_length.Minimum;

        pb_length.Value = value;           
    }

    private void pb_length_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        setLength(e.X);
    }
    
    private void nud_length_ValueChanged(object sender, EventArgs e) => setLength((int)nud_length.Value);

    private void pb_length_MouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        setLength(e.X);
    }
}