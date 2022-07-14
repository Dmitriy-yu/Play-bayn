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
    public partial class Form2 : Form
    {
        SoundPlayer sp = new SoundPlayer($"Баян_ Яблочко. (256  kbps).wav");
        public Form2()
        {
            InitializeComponent();
            sp.Play();          
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          Form  form3 = new Form3();
            form3.Show();
            sp.Stop();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            sp.Stop();           
        }

       

	}

    
}
