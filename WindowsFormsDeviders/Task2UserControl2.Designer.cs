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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonFindFiveDividers = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonInfo1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(817, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задача 2. Поиск чисел с 5-ю делителями на отрезке";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "                        ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(4, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(65, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите m:                ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(57, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "                        ";
            // 
            // textBoxM
            // 
            this.textBoxM.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxM.Location = new System.Drawing.Point(419, 111);
            this.textBoxM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(312, 32);
            this.textBoxM.TabIndex = 11;
            this.textBoxM.Text = "0";
            this.textBoxM.TextChanged += new System.EventHandler(this.textBoxM_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(65, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введите n:                 ";
            // 
            // textBoxN
            // 
            this.textBoxN.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(419, 159);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(312, 32);
            this.textBoxN.TabIndex = 13;
            this.textBoxN.Text = "0";
            // 
            // buttonFindFiveDividers
            // 
            this.buttonFindFiveDividers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFindFiveDividers.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindFiveDividers.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFindFiveDividers.Location = new System.Drawing.Point(740, 149);
            this.buttonFindFiveDividers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFindFiveDividers.Name = "buttonFindFiveDividers";
            this.buttonFindFiveDividers.Size = new System.Drawing.Size(189, 48);
            this.buttonFindFiveDividers.TabIndex = 14;
            this.buttonFindFiveDividers.Text = "Найти";
            this.buttonFindFiveDividers.UseVisualStyleBackColor = false;
            this.buttonFindFiveDividers.Click += new System.EventHandler(this.buttonSearchTask2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(65, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "Подходящие числа:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(419, 207);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(89, 234);
            this.listBox1.TabIndex = 16;
            // 
            // buttonInfo1
            // 
            this.buttonInfo1.Image = global::WindowsFormsDeviders.Properties.Resources.information_symbol_in_a_square1;
            this.buttonInfo1.Location = new System.Drawing.Point(11, 38);
            this.buttonInfo1.Name = "buttonInfo1";
            this.buttonInfo1.Size = new System.Drawing.Size(36, 37);
            this.buttonInfo1.TabIndex = 17;
            this.buttonInfo1.UseVisualStyleBackColor = true;
            this.buttonInfo1.Click += new System.EventHandler(this.buttonInfo1_Click);
            // 
            // Task2UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.buttonInfo1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonFindFiveDividers);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Task2UserControl2";
            this.Size = new System.Drawing.Size(955, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonFindFiveDividers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonInfo1;
    }
}
