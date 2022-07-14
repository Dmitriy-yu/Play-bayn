using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuestionsForStudents
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string[] files;
        string[] files1;
        string[] files2;
        string[] files3;
        string[] files4;
        string[] files5;
        string[] files6;
        string[] files7;
        string[] files8;
        string[] files9;
        int index;      
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(files1[index++]);
            if (index==files1.Length)
            {
                index = 0;
            }
   
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            files = Directory.GetFiles(@"Картинки\1.Тема");
            files1 = Directory.GetFiles(@"Картинки\2.Тема");
            files2 = Directory.GetFiles(@"Картинки\3.Тема");
            files3 = Directory.GetFiles(@"Картинки\4.Тема");
            files4 = Directory.GetFiles(@"Картинки\5.Тема");
            files5 = Directory.GetFiles(@"Картинки\6.Тема");
            files6 = Directory.GetFiles(@"Картинки\7.Тема");
            files7 = Directory.GetFiles(@"Картинки\8.Тема");
            files8 = Directory.GetFiles(@"Картинки\9.Тема");
            files9 = Directory.GetFiles(@"Картинки\10.Тема");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            form6.listBox1.Items.Clear();
            form6.listBox1.Items.AddRange(File.ReadAllLines(@"Картинки\2.Учим ноты.txt", Encoding.UTF8));
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = new Bitmap(files2[index++]);
                if (index == files2.Length)
                {
                    index = 0;
                }
              
            }
            catch (Exception)
            {
                MessageBox.Show("Чтобы перейти к следующему уроку" +
                          " убедитесь, что вы освоили этот урок", "Внимание!!!!!",MessageBoxButtons.OK,
                           MessageBoxIcon.Stop);
            }          
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            form6.listBox1.Items.AddRange(File.ReadAllLines(@"Картинки\3.Учим расположение нот для левой руки.txt", Encoding.UTF8));

        }
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Выучите ноты так как показано в описании!" +
                            " 2.Для тренировки запоминания в нотной тетради напишите все ноты" +
                             "от до- до- до 1 октавы.2.Запомните раположение нот по принципу до на первой добавочной линии," +
                              "ре под первой линией и т.д.!3.Запомните длительности нот!4.Назовите ноты!","Задание",MessageBoxButtons.OK,
                              MessageBoxIcon.Information);        
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.axWindowsMediaPlayer1.URL=($"Видео\\Oblivion.mp4");
            form5.Show();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            form5.axWindowsMediaPlayer1.URL=($"Видео\\Баян микс Катя.mp4");          
        }
        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сядьте так как показано на рисунках ( Не сутультесь,обратите внимание,чтобы мех лежал" +
                            " строго на левой ноге,а баян лежал паралельно полу !","Задание!!!!",MessageBoxButtons.OK,
                              MessageBoxIcon.Information);              
        }
        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Запомните расположение нот и аккордов на левой руке. " +
                "2.Сыграйте 3 пальцем всю последовательность вперед и назад.",
                  "Задание!!!!", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(files3[index++]);
            if (index == files3.Length)
            {
                index = 0;
            }

        }
        private void button15_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            form6.listBox1.Items.Clear();
            form6.listBox1.Items.AddRange(File.ReadAllLines(@"Картинки\4.Играем левой рукой.txt", Encoding.UTF8));
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(files[index++]);
            if (index == files.Length)
                index = 0;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            form6.listBox1.Items.Clear();
            form6.listBox1.Items.AddRange(File.ReadAllLines(@"Картинки\1.Посадка.txt", Encoding.UTF8));

        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Сядьте так как показано на рисунках ( Не сутультесь,обратите внимание,чтобы мех лежал" +
                            " строго на левой ноге,а баян лежал паралельно полу !", "Задание!!!!", MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
        }
 

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Запомните длительности нот!2.Запомните номера пальцев.2.Сыграйте упражнения " +
                            " без ошибок с правильно сменой мех.3.Выучите польку(Играйте все остро отрывисто" +
                            "не тяните звуки.)4.Играйте и пойте частушку (Можно придумать свои частушки и петь уже" +
                            "как концертный номер.)", "Задание!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сыграйте гамму до- мажор вверх и вниз.(Пропевайте ноты паралельно когда" +
                          " играете. Играйте без ошибок и старайтесь не смотреть на клавиатуру.)", "Задание!!!", MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
        }
        private void button28Task6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(files5[index++]);
            if (index==files6.Length)
            {
                index = 0;
            }
        }
        private void button24Task5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(files5[index ++]);
            if (index==files5.Length)
            {
                index = 0;
            }
        }
        private void button29_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(files6[index++]);
            if (index==files6.Length)
            {
                index =0;
            }
           
        }
        private void button27Task6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            form6.listBox1.Items.Clear();
            form6.listBox1.Items.AddRange(File.ReadAllLines(@"Картинки\6.Играем правой рукой.txt"));

        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Выучите наизучть все прозведения,которые представлены в данном уроке","Задание",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            form6.listBox1.Items.Clear();
            form6.listBox1.Items.AddRange(File.ReadAllLines(@"Картинки\5.Учим расположение нот для правой руки.txt"));
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            form6.listBox1.Items.Clear();
            form6.listBox1.Items.AddRange(File.ReadAllLines(@"Картинки\7.Играем  двумя руками.txt",Encoding.UTF8));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(files7[index++]);
            if (index==files7.Length)
            {
                index = 0;
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            form6.listBox1.Items.Clear();
            form6.listBox1.Items.AddRange(File.ReadAllLines(@"Картинки\8. Маленькая палька ,Елочка.txt", Encoding.UTF8));
        }
        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Запомните основные штрихи.2.Сыграйте Василек (Обратите внимание ,что нужно играть ноты в правой руке легато," +
                " а в левой стаккато)3.Елочку нужно играть весело ,не быстро. Единственное сложное место-это преход с ноты" +
                "до на ноту ля .4. Маленькая полька- звучать должна ярко и торжественно (как марш) ноты не лигуйте , все отрывисто" +
                " звонко.","Задание!!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        private void button33_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(files8[index++]);
            if (index==files8.Length)
            {
                index = 0;
            }

        }
        private void button32_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            form6.listBox1.Items.Clear();
            form6.listBox1.Items.AddRange(File.ReadAllLines(@"Картинки\9. Нота с точкой и Во кузнице.txt", Encoding.UTF8 ));
        }
        private void button30_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Запомните определение ноты с точкой(Она будет вам встречаться часто)2.Выучите как в описании все представленные произведения" +
                " и только после этого переходите к заключительному уроку!", "Задание!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void button37_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(files9[index++]);
            if (index==files9.Length)
            {
                index = 0;
            }

        }

        private void button34_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Запомните определение и найдите на клавиатуре Ноы соль #, ля b, ре # 2. Выучите каждой рукой отдельно Яблочко затем соедените двумя руками." +
                "3. Цыганочка является завершающей песней. Если что- то не понятно Вам в нотном матерале,  вернитесь к предыдущим урокам","Задание!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}