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
    public partial class Task4UserControl4 : UserControl
    {
        public Task4UserControl4()
        {
            InitializeComponent();
        }

        private void buttonSearchTask2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (int.TryParse(textBoxN.Text, out int N) && N > 0)
            {
                // Вывод первых N простых чисел
                var primeNumbers = ClassDividers.ProstDiv(N);
                foreach (var prime in primeNumbers)
                {
                    listBox1.Items.Add(prime);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите натуральное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Вызов формы со справкой
        private void buttonInfo4_Click(object sender, EventArgs e)
        {
            InfoForm1 infoForm1 = new InfoForm1(3);
            infoForm1.ShowDialog();
        }
    }
}
