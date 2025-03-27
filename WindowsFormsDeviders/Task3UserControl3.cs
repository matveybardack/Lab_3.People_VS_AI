using System;
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
            textBox1.Text = string.Empty;
            if (int.TryParse(textBoxN.Text, out int N) && N > 1)
            {
                var primeFactorio = ClassDividers.Factoria(N);
                int i = 0;
                foreach (var factor in primeFactorio)
                {
                    i++;
                    if (i != primeFactorio.Count)
                        textBox1.Text += String.Format("{0} * ", factor);
                    else
                        textBox1.Text += String.Format("{0}", factor);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите натуральное число больше 1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo3_Click(object sender, EventArgs e)
        {
            InfoForm1 infoForm1 = new InfoForm1(2);
            infoForm1.ShowDialog();
        }
    }
}
