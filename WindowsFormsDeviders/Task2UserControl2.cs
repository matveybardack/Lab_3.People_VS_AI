﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryDividers;

namespace WindowsFormsDeviders
{
    public partial class Task2UserControl2 : UserControl
    {
        public Task2UserControl2()
        {
            InitializeComponent();
        }

        private void buttonSearchTask2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (int .TryParse(textBoxM.Text, out int m) && int .TryParse(textBoxN.Text, out int n))
            {
                if (m < 1 ||  n < 1)
                {
                    MessageBox.Show("Пожалуйста, введите натуральные числа для M и N.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (m > n)
                {
                    MessageBox.Show("Левый конец отрезка (M) должен быть не больше правого (N)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Заполнение списка чисел с 5ю делителями
                var numbersWithFiveDividers = ClassDividers.FiveDividers(m, n);
                foreach (var numbers in numbersWithFiveDividers)
                { listBox1.Items.Add(numbers);}
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите натуральные числа для M и N.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Вызов формы со справкой
        private void buttonInfo2_Click(object sender, EventArgs e)
        {
            InfoForm1 infoForm1 = new InfoForm1(1);
            infoForm1.ShowDialog();
        }
    }
}
