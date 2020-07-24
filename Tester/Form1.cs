using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class Form1 : Form
    {
        int[] answer;
        int n = 0;
        class Questions
        {

            protected string qustion;

            protected internal virtual string Qustion
            {
                get { return qustion; }

            }
            protected string answer1;

            protected internal virtual string Answer1
            {
                get { return answer1; }

            }
            protected string answer2;

            protected internal virtual string Answer2
            {
                get { return answer2; }

            }
            protected string answer3;

            protected internal virtual string Answer3
            {
                get { return answer3; }

            }





            public Questions(string Question, string a, string b, string c)
            {

                this.qustion = Question;
                this.answer1 = a;
                this.answer2 = b;
                this.answer3 = c;



            }
        }
        public Form1()
        {
            answer = new int[23]; //!!!!!!!!!!!!!!!!!!!  

            Questions[] q = { new Questions("Найти полное сопротивление R показанной \n на рисунке цепи если\n R1=R2=R5=R6=3 Ом, R4=24 Ом, R3 = 20 Ом", "18 Ом", "24 Ом", "20 Ом") };

            InitializeComponent();
            label1.Text = q[0].Qustion;
            pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A1);
            radioButton1.Text = q[0].Answer1;
            radioButton2.Text = q[0].Answer2;
            radioButton3.Text = q[0].Answer3;

        }
        public void show(int n)
        {

            Questions[] q = { new Questions("Найти полное сопротивление R показанной \n на рисунке цепи если\n R1=R2=R5=R6=3 Ом, R4=24 Ом, R3 = 20 Ом", "18 Ом", "24 Ом", "20 Ом"),
                            new Questions("Определите общее сопротивление цепи, изображенной на рисунке,\n если R1=1/2 Ом, R2=3/2 Ом, R3 = R4 = R6 = 1 Ом, R5 = 2/3 Ом.", "1 Ом", "0,5 Ом", "2 Ом"),
                            new Questions("Определите общее сопротивление электрической цепи, изображенной на рисунке, если R = 2 Ом.", "4 Ом", "2 Ом", "1 Ом"),
                            new Questions("Определить электроёмкость батареи конденсаторов, если C1=0,1 мкФ, С2=0,4мкФ и С3= 0,5мкФ", "10 мкФ", "0,6 мкФ", "3 мкФ"),
                            new Questions("Определить электроёмкость батареи конденсаторов, если C1= С2= 2 мкФ, С3= С4= С5=6 мкФ", "8 мкФ", "3 мкФ", "4 мкФ"),
                            new Questions("Мостовая однофазная  схема выпрямления имеет вид:", "1", "2", "3"),
                            new Questions("Указать внешнюю характеристику выпрямителя  с L-фильтром", "1", "2", "3"),
                            new Questions("Схема включения транзистора с общим коллектором имеет вид   :", "1", "2", "3"),
                            new Questions("Указать выходные харрактеристики биполярного транзистора в схеме ОЭ", "1", "2", "3"),
                            new Questions("Указать материал, из которого изготовлен транзистор 2T805А", "германий", "кремний", "арсенид галлия"),
                            new Questions("Схема LC фильтра имеет вид", "1", "2", "3"),
                            new Questions("Схема включения емкостного фильтра имеет вид", "1", "2", "3"),
                            new Questions("Коэффициент пульсации выпрямителя определяется по выражению:", "1", "2", "3"),
                            new Questions("Почему транзисторы называются *биполярными*\n потому что в образовании тока участвуют", "дырки", "электроны", "дырки и электроны"),
                            new Questions("Указать правильное значение коэффециента передачи тока\n биполярного транзистора", "α=995/999", "α=0,995/0,999", "α>>1"),
                            new Questions("При увеличении емкости сглаживающего C-фильтра\n коэффициент сглаживания", "уменьшается", "увеличивается", "остается без изменений"),
                            new Questions("Регулированная характеристика упрявляемого\n выпрямителя имеет вид", "1", "2", "3"),
                            new Questions("Указать транзистор n-p-n типа", "1", "2", "3"),
                            new Questions("Указать правильное выражение\n для коэффициента передачи тока транзистора", "β>=1", "β<<1", "β>>1"),
                            new Questions("Указать амплитудно-частотную характеристику усилителя ОЭ", "1", "2", "3"),
                            new Questions("Указать выражение для определения коэффициента передачи тока базы биполярного транзистора", "1", "2", "3"),
                            new Questions("Схема включения транзистора с ОЭ имеет вид", "1", "2", "3"),
                            new Questions("Полевые транзисторы имеют стоковые характеристики следующего вида", "1", "2", "3")};
            switch (answer[n])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    break;

            }
            switch (n) //!!!!!!!!!!!!!!!!!!!
            {
                case 0:
                    label1.Text = q[0].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A1);
                    radioButton1.Text = q[0].Answer1;
                    radioButton2.Text = q[0].Answer2;
                    radioButton3.Text = q[0].Answer3;
                    break;
                case 1:
                    label1.Text = q[1].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A2);
                    radioButton1.Text = q[1].Answer1;
                    radioButton2.Text = q[1].Answer2;
                    radioButton3.Text = q[1].Answer3;
                    break;
                case 2:
                    label1.Text = q[2].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A3);
                    radioButton1.Text = q[2].Answer1;
                    radioButton2.Text = q[2].Answer2;
                    radioButton3.Text = q[2].Answer3;
                    break;
                case 3:
                    label1.Text = q[3].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A4);
                    radioButton1.Text = q[3].Answer1;
                    radioButton2.Text = q[3].Answer2;
                    radioButton3.Text = q[3].Answer3;
                    break;
                case 4:
                    label1.Text = q[4].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A5);
                    radioButton1.Text = q[4].Answer1;
                    radioButton2.Text = q[4].Answer2;
                    radioButton3.Text = q[4].Answer3;
                    break;
                case 5:
                    label1.Text = q[5].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A6);
                    radioButton1.Text = q[5].Answer1;
                    radioButton2.Text = q[5].Answer2;
                    radioButton3.Text = q[5].Answer3;
                    break;
                case 6:
                    label1.Text = q[6].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A7);
                    radioButton1.Text = q[6].Answer1;
                    radioButton2.Text = q[6].Answer2;
                    radioButton3.Text = q[6].Answer3;
                    break;
                case 7:
                    label1.Text = q[7].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A8);
                    radioButton1.Text = q[7].Answer1;
                    radioButton2.Text = q[7].Answer2;
                    radioButton3.Text = q[7].Answer3;
                    break;
                case 8:
                    label1.Text = q[8].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A9);
                    radioButton1.Text = q[8].Answer1;
                    radioButton2.Text = q[8].Answer2;
                    radioButton3.Text = q[8].Answer3;
                    break;
                case 9:
                    label1.Text = q[9].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A25);
                    radioButton1.Text = q[9].Answer1;
                    radioButton2.Text = q[9].Answer2;
                    radioButton3.Text = q[9].Answer3;
                    break;
                case 10:
                    label1.Text = q[10].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A11);
                    radioButton1.Text = q[10].Answer1;
                    radioButton2.Text = q[10].Answer2;
                    radioButton3.Text = q[10].Answer3;
                    break;
                case 11:
                    label1.Text = q[11].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.AA);
                    radioButton1.Text = q[11].Answer1;
                    radioButton2.Text = q[11].Answer2;
                    radioButton3.Text = q[11].Answer3;
                    break;
                case 12:
                    label1.Text = q[12].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.AAA);
                    radioButton1.Text = q[12].Answer1;
                    radioButton2.Text = q[12].Answer2;
                    radioButton3.Text = q[12].Answer3;
                    break;
                case 13:
                    label1.Text = q[13].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A25);
                    radioButton1.Text = q[13].Answer1;
                    radioButton2.Text = q[13].Answer2;
                    radioButton3.Text = q[13].Answer3;
                    break;
                case 14:
                    label1.Text = q[14].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A25);
                    radioButton1.Text = q[14].Answer1;
                    radioButton2.Text = q[14].Answer2;
                    radioButton3.Text = q[14].Answer3;
                    break;
                case 15:
                    label1.Text = q[15].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A25);
                    radioButton1.Text = q[15].Answer1;
                    radioButton2.Text = q[15].Answer2;
                    radioButton3.Text = q[15].Answer3;
                    break;
                case 16:
                    label1.Text = q[16].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A17);
                    radioButton1.Text = q[16].Answer1;
                    radioButton2.Text = q[16].Answer2;
                    radioButton3.Text = q[16].Answer3;
                    break;
                case 17:
                    label1.Text = q[17].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A18);
                    radioButton1.Text = q[17].Answer1;
                    radioButton2.Text = q[17].Answer2;
                    radioButton3.Text = q[17].Answer3;
                    break;
                case 18:
                    label1.Text = q[18].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A25);
                    radioButton1.Text = q[18].Answer1;
                    radioButton2.Text = q[18].Answer2;
                    radioButton3.Text = q[18].Answer3;
                    break;
                case 19:
                    label1.Text = q[19].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A20);
                    radioButton1.Text = q[19].Answer1;
                    radioButton2.Text = q[19].Answer2;
                    radioButton3.Text = q[19].Answer3;
                    break;
                case 20:
                    label1.Text = q[20].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A21);
                    radioButton1.Text = q[20].Answer1;
                    radioButton2.Text = q[20].Answer2;
                    radioButton3.Text = q[20].Answer3;
                    break;
                case 21:
                    label1.Text = q[21].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A22);
                    radioButton1.Text = q[21].Answer1;
                    radioButton2.Text = q[21].Answer2;
                    radioButton3.Text = q[21].Answer3;
                    break;
                case 22:
                    label1.Text = q[22].Qustion;
                    pictureBox1.BackgroundImage = new Bitmap(Tester.Properties.Resources.A23);
                    radioButton1.Text = q[22].Answer1;
                    radioButton2.Text = q[22].Answer2;
                    radioButton3.Text = q[22].Answer3;
                    break;




            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n++;
            if (n > 22) n = 22; //!!!!!!!!!!!!!!!!!!!
            show(n);
        }

        private void Down_Click(object sender, EventArgs e)
        {
            n--;
            if (n < 0) n = 0;
            show(n);
        }

        private void Go_Click(object sender, EventArgs e)
        {
            int correct = 0;
            if (answer[0] == 1)
                correct++;
            if (answer[1] == 2)
                correct++;
            if (answer[2] == 2)
                correct++;
            if (answer[3] == 2)
                correct++;
            if (answer[4] == 2)
                correct++;
            if (answer[5] == 3)
                correct++;
            if (answer[6] == 1)
                correct++;
            if (answer[7] == 3)
                correct++;
            if (answer[8] == 3)
                correct++;
            if (answer[9] == 2)
                correct++;
            if (answer[10] == 2)
                correct++;
            if (answer[11] == 2)
                correct++;
            if (answer[12] == 2)
                correct++;
            if (answer[13] == 3)
                correct++;
            if (answer[14] == 2)
                correct++;
            if (answer[15] == 2)
                correct++;
            if (answer[16] == 2)
                correct++;
            if (answer[17] == 2)
                correct++;
            if (answer[18] == 3)
                correct++;
            if (answer[19] == 1)
                correct++;
            if (answer[20] == 2)
                correct++;
            if (answer[21] == 1)
                correct++;
            if (answer[22] == 3)
                correct++;
            
            int prcnt = correct * 100 / 23; //!!!!!!!!!!!!!!!!!!!
            String msg = "Вы не прошли тест.";
            if (prcnt > 65) msg = "Вы прошли тест.";
            MessageBox.Show("Вы прошли тест на " + prcnt + " процентов. " + msg + " Количество верных ответов- " + correct);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 3;
        }
    }
}
