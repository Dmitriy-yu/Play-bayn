using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsForStudents
{
    public partial class Form3 : Form
    {
        SoundPlayer sp = new SoundPlayer(@"C:Вивальди.wav");

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.PlayLooping();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            int mistake = 0;

            if (radioButton2.Checked == true)
            {
                count += 1;
                label8.Text = "Верно";
                label8.ForeColor = Color.Green;
            }
            if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true)
             {
                mistake += 1;
                label8.Text = "Не верно";
                label8.ForeColor = Color.Red;
            }
            if (radioButton7.Checked == true)
            {
                count += 1;
                label9.Text = "Верно";
                label9.ForeColor = Color.Green;
            }
            if (radioButton5.Checked == true || radioButton6.Checked == true ||radioButton8.Checked == true) 
            {
                mistake += 1;
                label9.Text = "Не верно";
                label9.ForeColor = Color.Red;
            }

            if (radioButton9.Checked==true)
            {
                count += 1;
                label10.Text = "Верно";
                label10.ForeColor = Color.Green;
            }
            if (radioButton10.Checked == true || radioButton11.Checked == true) 
            {
                mistake += 1;
                label10.Text = "Не верно";
                label10.ForeColor = Color.Red;
            }
            if (radioButton12.Checked==true)
            {
                count += 1;
                label11.Text = "Верно";
                label11.ForeColor = Color.Green;
            }
            if (radioButton14.Checked == true || radioButton13.Checked == true) 
            {
                mistake += 1;
                label11.Text = "Не верно";
                label11.ForeColor = Color.Red;
            }  
            if (radioButton15.Checked==true)
            {
                count += 1;
                label12.Text = "Верно";
                label12.ForeColor = Color.Green;
            }
            if (radioButton16.Checked == true ||radioButton17.Checked == true) 
            {
                mistake += 1;
                label12.Text = "Не верно";
                label12.ForeColor = Color.Red;
            }

            label3.Text = "Ваш результат равен:" + Convert.ToInt32(count);
            label3.ForeColor = Color.Green;
            label6.Text = "Oшибки :" + Convert.ToInt32(mistake);
            label6.ForeColor = Color.Red;
        }
    }
}
