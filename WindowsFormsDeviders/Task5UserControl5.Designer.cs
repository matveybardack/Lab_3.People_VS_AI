﻿namespace WindowsFormsDeviders
{
    partial class Task5UserControl5
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
            this.buttonSearchTask2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonInfo5 = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(785, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Задача 5. Первые N простых чисел по алгоритму Эратосфена";
            // 
            // buttonSearchTask2
            // 
            this.buttonSearchTask2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearchTask2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchTask2.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearchTask2.Location = new System.Drawing.Point(452, 68);
            this.buttonSearchTask2.Name = "buttonSearchTask2";
            this.buttonSearchTask2.Size = new System.Drawing.Size(142, 39);
            this.buttonSearchTask2.TabIndex = 25;
            this.buttonSearchTask2.Text = "Найти";
            this.buttonSearchTask2.UseVisualStyleBackColor = false;
            this.buttonSearchTask2.Click += new System.EventHandler(this.buttonSearchTask2_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(44, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(401, 33);
            this.label7.TabIndex = 23;
            this.label7.Text = "Первые N простых чисел:";
            // 
            // textBoxN
            // 
            this.textBoxN.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(218, 78);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(227, 27);
            this.textBoxN.TabIndex = 22;
            this.textBoxN.Text = "0";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(44, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "Введите N:    ";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(456, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 235);
            this.listBox1.TabIndex = 26;
            // 
            // buttonInfo5
            // 
            this.buttonInfo5.Image = global::WindowsFormsDeviders.Properties.Resources.information_symbol_in_a_square1;
            this.buttonInfo5.Location = new System.Drawing.Point(11, 31);
            this.buttonInfo5.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo5.Name = "buttonInfo5";
            this.buttonInfo5.Size = new System.Drawing.Size(27, 30);
            this.buttonInfo5.TabIndex = 27;
            this.buttonInfo5.UseVisualStyleBackColor = true;
            this.buttonInfo5.Click += new System.EventHandler(this.buttonInfo5_Click);
            // 
            // Task5UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.buttonInfo5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonSearchTask2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Task5UserControl5";
            this.Size = new System.Drawing.Size(839, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchTask2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonInfo5;
    }
}
