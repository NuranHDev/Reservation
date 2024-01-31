using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(DBSQL.conString);

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 30;
            int day = Convert.ToInt32(textBox5.Text);
            int total = price * day;

            textBox10.Text = total.ToString();
            connect.Open();
            string script = @"INSERT INTO Clients(NAME,SURNAME,TEL,PERSON_COUNT,DAY,DATE,FLOOR,ROOM,CardNumber,PRICE,STATUS)
                VALUES(@name,@surname,@tel,@person_count,@day,@date,@floor,@room,@cardnumber,@price,@status)";
            SqlCommand command = new SqlCommand(script,connect);
            command.Parameters.AddWithValue("@name", textBox1.Text);
            command.Parameters.AddWithValue("@surname", textBox2.Text);
            command.Parameters.AddWithValue("@tel", textBox3.Text);
            command.Parameters.AddWithValue("@person_count", textBox4.Text);
            command.Parameters.AddWithValue("@day", textBox5.Text);
            command.Parameters.AddWithValue("@date", textBox6.Text);
            command.Parameters.AddWithValue("@floor", comboBox1.Text);
            command.Parameters.AddWithValue("@room", comboBox2.Text);
            command.Parameters.AddWithValue("@cardnumber", textBox9.Text);
            command.Parameters.AddWithValue("@price", textBox10.Text);
            command.Parameters.AddWithValue("@status", textBox11.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Rezervasiya edildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminLogin next = new adminLogin();
            next.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int price = 30;
            int  day=Convert.ToInt32(textBox5.Text);
            int total = price * day;
            label14.Text = $"Ödəniləcək Mebleğ:{total.ToString()} AZN";
        }
    }
}
