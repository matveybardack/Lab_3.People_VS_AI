namespace WindowsFormsDeviders
{
    partial class Task2UserControl2
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonFindFiveDividers = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonInfo2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задача 2. Поиск чисел с 5-ю делителями на отрезке";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите M:                ";
            // 
            // textBoxM
            // 
            this.textBoxM.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxM.Location = new System.Drawing.Point(311, 77);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(235, 27);
            this.textBoxM.TabIndex = 11;
            this.textBoxM.Text = "0";
            this.textBoxM.TextChanged += new System.EventHandler(this.textBoxM_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(44, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введите N:                 ";
            // 
            // textBoxN
            // 
            this.textBoxN.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(311, 116);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(235, 27);
            this.textBoxN.TabIndex = 13;
            this.textBoxN.Text = "0";
            // 
            // buttonFindFiveDividers
            // 
            this.buttonFindFiveDividers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFindFiveDividers.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindFiveDividers.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFindFiveDividers.Location = new System.Drawing.Point(552, 106);
            this.buttonFindFiveDividers.Name = "buttonFindFiveDividers";
            this.buttonFindFiveDividers.Size = new System.Drawing.Size(142, 39);
            this.buttonFindFiveDividers.TabIndex = 14;
            this.buttonFindFiveDividers.Text = "Найти";
            this.buttonFindFiveDividers.UseVisualStyleBackColor = false;
            this.buttonFindFiveDividers.Click += new System.EventHandler(this.buttonSearchTask2_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(44, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "Подходящие числа:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(311, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(68, 193);
            this.listBox1.TabIndex = 16;
            // 
            // buttonInfo2
            // 
            this.buttonInfo2.Image = global::WindowsFormsDeviders.Properties.Resources.information_symbol_in_a_square1;
            this.buttonInfo2.Location = new System.Drawing.Point(11, 31);
            this.buttonInfo2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo2.Name = "buttonInfo2";
            this.buttonInfo2.Size = new System.Drawing.Size(27, 30);
            this.buttonInfo2.TabIndex = 17;
            this.buttonInfo2.UseVisualStyleBackColor = true;
            this.buttonInfo2.Click += new System.EventHandler(this.buttonInfo2_Click);
            // 
            // Task2UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.buttonInfo2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonFindFiveDividers);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Task2UserControl2";
            this.Size = new System.Drawing.Size(716, 361);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonFindFiveDividers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonInfo2;
    }
}
