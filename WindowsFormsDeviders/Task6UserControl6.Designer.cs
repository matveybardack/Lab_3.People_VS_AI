namespace WindowsFormsDeviders
{
    partial class Task6UserControl6
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSearchTask2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonInfo6 = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(423, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Задача 6. Нахождение НОД(N, M)";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(44, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Введите N:    ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(44, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Введите M:   ";
            // 
            // textBoxN
            // 
            this.textBoxN.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(217, 77);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(250, 27);
            this.textBoxN.TabIndex = 17;
            this.textBoxN.Text = "0";
            // 
            // textBoxM
            // 
            this.textBoxM.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxM.Location = new System.Drawing.Point(217, 116);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(250, 27);
            this.textBoxM.TabIndex = 18;
            this.textBoxM.Text = "0";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(44, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 33);
            this.label6.TabIndex = 20;
            this.label6.Text = "НОД(N, M)    ";
            // 
            // buttonSearchTask2
            // 
            this.buttonSearchTask2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearchTask2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchTask2.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearchTask2.Location = new System.Drawing.Point(474, 106);
            this.buttonSearchTask2.Name = "buttonSearchTask2";
            this.buttonSearchTask2.Size = new System.Drawing.Size(142, 39);
            this.buttonSearchTask2.TabIndex = 21;
            this.buttonSearchTask2.Text = "Найти";
            this.buttonSearchTask2.UseVisualStyleBackColor = false;
            this.buttonSearchTask2.Click += new System.EventHandler(this.buttonSearchTask2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(217, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(250, 27);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "0";
            // 
            // buttonInfo6
            // 
            this.buttonInfo6.Image = global::WindowsFormsDeviders.Properties.Resources.information_symbol_in_a_square1;
            this.buttonInfo6.Location = new System.Drawing.Point(11, 31);
            this.buttonInfo6.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo6.Name = "buttonInfo6";
            this.buttonInfo6.Size = new System.Drawing.Size(27, 30);
            this.buttonInfo6.TabIndex = 28;
            this.buttonInfo6.UseVisualStyleBackColor = true;
            this.buttonInfo6.Click += new System.EventHandler(this.buttonInfo6_Click);
            // 
            // Task6UserControl6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.buttonInfo6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSearchTask2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Task6UserControl6";
            this.Size = new System.Drawing.Size(881, 505);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSearchTask2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonInfo6;
    }
}
