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
    public partial class Task3UserControl3 : UserControl
    {
        public Task3UserControl3()
        {
            InitializeComponent();
        }

        private void buttonSearchTask2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (int .TryParse(textBoxN.Text, out int N) && N > 1)
            {
                var primeFactorio = ClassDividers.Factoria(N);
                foreach (var factor in primeFactorio)
                {
                    listBox1.Items.Add(factor);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите натуральное число больше 1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
