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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsDeviders
{
    public partial class Task7UserControl7 : UserControl
    {
        public Task7UserControl7()
        {
            InitializeComponent();
        }

        private void buttonSearchTask2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxM.Text, out int m) && int.TryParse(textBoxN.Text, out int n))
            {
                if (m < 1 || n < 1)
                {
                    MessageBox.Show("Пожалуйста, введите натуральные числа для m и n.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int nok = ClassDividers.NOK(m, n);
                textBox1.Text = nok.ToString();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите натуральные числа для m и n.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo6_Click(object sender, EventArgs e)
        {
            InfoForm1 infoForm1 = new InfoForm1(6);
            infoForm1.ShowDialog();
        }
    }
}
