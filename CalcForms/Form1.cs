//.NET 6.0
//Рабочая версия 1
using LibaryForFormsCalc;

namespace CalcForms
{

    public partial class Form1 : Form
    {
        Calc c = new Calc();


        //Переменные для данных цифр и действий.
        string sA, sB, sAction, sTemp;
        double dA, dB;

        //Флаг. True - если ввели А, False - если ещё не ввели A.
        bool fA = false;

        //Флаг для выполнения вычислений
        bool fB = false;

        //Флаг для минуса
        bool fMinus = false;

        //Флаг для точки
        //True - есть точка, False - нет точки
        bool fPoint = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Action(string sAction)
        {
            if (!fA)
            {
                sA += textBox.Text;
            }
            else
            {
                sB += textBox.Text;
                fB = true;
            }

            c.divByZero += C_divByZero;

            fA = true;
            textBox.Text += sAction;

            if (fB)
            {
                c.getSign = label.Text.Substring(label.Text.Length - 1);
                /*if (calc.getSign == "/" & Convert.ToDouble(sB) == 0)
                {
                    MessageBox.Show("На нуль делить нельзя!");
                }
                else
                {


                    label.Text = dA + sAction;
                }*/
                /*calc.sA = sA;
                  calc.sB = sB;*/
                dA = Convert.ToDouble(sA);
                c.A = Convert.ToDouble(sA);
                c.B = Convert.ToDouble(sB);

                dA = c.Action();

                sA = dA.ToString();

                if (Convert.ToDouble(sB) != 0)
                {
                    label.Text = sA + sAction;
                }
                sB = "";


                //label.Text = sA + sAction;
            }
            else
            {
                label.Text = textBox.Text;
            }
            textBox.Clear();
            fMinus = true;
            fPoint = false;
        }

        private void C_divByZero()
        {
            MessageBox.Show("Деление на нуль!");
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonOne.Text);
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonTwo.Text);
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonThree.Text);
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonFour.Text);
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonFive.Text);
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonSix.Text);
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonSeven.Text);
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonEight.Text);
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonNine.Text);
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonZero.Text);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length >= 1)
            {
                sAction = buttonPlus.Text;
                Action(sAction);
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length >= 1 || !fMinus)
            {
                fMinus = false;
                sAction = buttonMinus.Text;
                Action(sAction);
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length >= 1)
            {
                sAction = buttonMult.Text;
                Action(sAction);
            }
        }

        private void buttonDivided_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length >= 1)
            {
                sAction = buttonDivided.Text;
                Action(sAction);
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            int size = textBox.Text.Length;

            if (size > 0 && !fPoint)
            {
                textBox.AppendText(",");
                fPoint = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int size = textBox.Text.Length;

            if (size > 0)
            {
                textBox.Text = textBox.Text.Substring(0, size - 1);
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {

        }
    }
}
