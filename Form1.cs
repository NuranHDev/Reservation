using System.Data.SqlClient;

namespace Reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="Nuran"&& textBox2.Text=="123")
            {
                Reservation next = new Reservation();
                next.Show();
            }
            else
            {
                MessageBox.Show("istifadəçi adı vəya şifrə yanlışdır");
            }
           
        }
    }
}
