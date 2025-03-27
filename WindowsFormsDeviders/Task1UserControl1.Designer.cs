namespace WindowsFormsDeviders
{
    partial class Task1UserControl1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFindDividers = new System.Windows.Forms.Button();
            this.listBox1Dividers = new System.Windows.Forms.ListBox();
            this.buttonInfo1 = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(422, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задача 1. Поиск делителей числа";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(227, 77);
            this.textBox1.MinimumSize = new System.Drawing.Size(4, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите N:     ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(44, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Его делители:";
            // 
            // buttonFindDividers
            // 
            this.buttonFindDividers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFindDividers.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindDividers.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFindDividers.Location = new System.Drawing.Point(422, 69);
            this.buttonFindDividers.Name = "buttonFindDividers";
            this.buttonFindDividers.Size = new System.Drawing.Size(186, 36);
            this.buttonFindDividers.TabIndex = 5;
            this.buttonFindDividers.Text = "Найти";
            this.buttonFindDividers.UseVisualStyleBackColor = false;
            this.buttonFindDividers.Click += new System.EventHandler(this.buttonSearchTask1_Click);
            // 
            // listBox1Dividers
            // 
            this.listBox1Dividers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1Dividers.FormattingEnabled = true;
            this.listBox1Dividers.ItemHeight = 21;
            this.listBox1Dividers.Location = new System.Drawing.Point(227, 114);
            this.listBox1Dividers.Name = "listBox1Dividers";
            this.listBox1Dividers.Size = new System.Drawing.Size(87, 214);
            this.listBox1Dividers.TabIndex = 9;
            this.listBox1Dividers.SelectedIndexChanged += new System.EventHandler(this.listBox1Dividers_SelectedIndexChanged);
            // 
            // buttonInfo1
            // 
            this.buttonInfo1.Image = global::WindowsFormsDeviders.Properties.Resources.information_symbol_in_a_square1;
            this.buttonInfo1.Location = new System.Drawing.Point(11, 31);
            this.buttonInfo1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo1.Name = "buttonInfo1";
            this.buttonInfo1.Size = new System.Drawing.Size(27, 30);
            this.buttonInfo1.TabIndex = 10;
            this.buttonInfo1.UseVisualStyleBackColor = true;
            this.buttonInfo1.Click += new System.EventHandler(this.buttonInfo1_Click);
            // 
            // Task1UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.buttonInfo1);
            this.Controls.Add(this.listBox1Dividers);
            this.Controls.Add(this.buttonFindDividers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Task1UserControl1";
            this.Size = new System.Drawing.Size(651, 370);
            this.Load += new System.EventHandler(this.Task1UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFindDividers;
        private System.Windows.Forms.ListBox listBox1Dividers;
        private System.Windows.Forms.Button buttonInfo1;
    }
}
