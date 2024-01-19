using System;
using System.Windows.Forms;

namespace days_f_he_eek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {

            


        }

        private void btnCheckDay_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(tbInputDate.Text, out DateTime selectedDate))
            {
                string dayOfWeek = selectedDate.ToString("dddd");

                tbResult.Text = $"День тижня для {selectedDate.ToString()}: {dayOfWeek}";
            }
            else
            {
                MessageBox.Show("Некоректний формат Дати. Введіть дату у форматі дд.мм.рррр");
            }
        }
    }
}
