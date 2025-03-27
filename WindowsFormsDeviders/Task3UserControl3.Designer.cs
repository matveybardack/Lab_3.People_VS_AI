namespace WindowsFormsDeviders
{
    partial class Task3UserControl3
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
            this.buttonInfo3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSearchTask2 = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInfo3
            // 
            this.buttonInfo3.Image = global::WindowsFormsDeviders.Properties.Resources.information_symbol_in_a_square1;
            this.buttonInfo3.Location = new System.Drawing.Point(11, 31);
            this.buttonInfo3.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo3.Name = "buttonInfo3";
            this.buttonInfo3.Size = new System.Drawing.Size(27, 30);
            this.buttonInfo3.TabIndex = 18;
            this.buttonInfo3.UseVisualStyleBackColor = true;
            this.buttonInfo3.Click += new System.EventHandler(this.buttonInfo3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonInfo3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 75);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Задача 3. Факторизация числа";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(296, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(415, 27);
            this.textBox1.TabIndex = 25;
            // 
            // buttonSearchTask2
            // 
            this.buttonSearchTask2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearchTask2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchTask2.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearchTask2.Location = new System.Drawing.Point(531, 71);
            this.buttonSearchTask2.Name = "buttonSearchTask2";
            this.buttonSearchTask2.Size = new System.Drawing.Size(142, 37);
            this.buttonSearchTask2.TabIndex = 24;
            this.buttonSearchTask2.Text = "Найти";
            this.buttonSearchTask2.UseVisualStyleBackColor = false;
            this.buttonSearchTask2.Click += new System.EventHandler(this.buttonSearchTask2_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxN.Location = new System.Drawing.Point(291, 79);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(235, 27);
            this.textBoxN.TabIndex = 23;
            this.textBoxN.Text = "0";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(44, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 33);
            this.label6.TabIndex = 22;
            this.label6.Text = "Разложение числа:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(44, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "Введите N:              ";
            // 
            // Task3UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSearchTask2);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Task3UserControl3";
            this.Size = new System.Drawing.Size(714, 469);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonInfo3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSearchTask2;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}
