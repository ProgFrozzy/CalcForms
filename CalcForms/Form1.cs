//.NET 6.0
//������� ������
using LibaryForFormsCalc;

namespace CalcForms
{
    public partial class Form1 : Form
    {
        Calc calc = new Calc();
        //���������� ��� ������ ���� � ��������.
        string sA, sB, sAction, sTemp;
        double dA, dB;

        //����. True - ���� ����� �, False - ���� ��� �� ����� A.
        bool fA = false;

        //���� ��� ���������� ����������
        bool fB = false;

        //���� ��� ������
        bool fMinus = false;

        //���� ��� �����
        //True - ���� �����, False - ��� �����
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
            fA = true;
            textBox.Text += sAction;

            if (fB)
            {
                calc.getSign = label.Text.Substring(label.Text.Length - 1);
                if (calc.getSign == "/" & Convert.ToDouble(sB) == 0)
                {
                    MessageBox.Show("�� ���� ������ ������!");
                }
                else
                {
                    /*calc.sA = sA;
                    calc.sB = sB;*/

                    calc.A = Convert.ToDouble(sA);
                    calc.B = Convert.ToDouble(sB);

                    dA = calc.Action();

                    sA = dA.ToString();
                    sB = "";

                    label.Text = dA + sAction;
                }

            }
            else
            {
                label.Text = textBox.Text;
            }
            textBox.Clear();
            fMinus = true;
            fPoint = false;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonOne.Text);
            if (!fA)
            {
                sA += buttonOne.Text;
            }
            else
            {
                sB += buttonOne.Text;
                fB = true;
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonTwo.Text);
            if (!fA)
            {
                sA += buttonTwo.Text;
            }
            else
            {
                sB += buttonTwo.Text;
                fB = true;
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonThree.Text);
            if (!fA)
            {
                sA += buttonThree.Text;
            }
            else
            {
                sB += buttonThree.Text;
                fB = true;
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonFour.Text);
            if (!fA)
            {
                sA += buttonFour.Text;
            }
            else
            {
                sB += buttonFour.Text;
                fB = true;
            }
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonFive.Text);
            if (!fA)
            {
                sA += buttonFive.Text;
            }
            else
            {
                sB += buttonFive.Text;
                fB = true;
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonSix.Text);
            if (!fA)
            {
                sA += buttonSix.Text;
            }
            else
            {
                sB += buttonSix.Text;
                fB = true;
            }
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonSeven.Text);
            if (!fA)
            {
                sA += buttonSeven.Text;
            }
            else
            {
                sB += buttonSeven.Text;
                fB = true;
            }
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonEight.Text);
            if (!fA)
            {
                sA += buttonEight.Text;
            }
            else
            {
                sB += buttonEight.Text;
                fB = true;
            }
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBox.AppendText(buttonNine.Text);
            if (!fA)
            {
                sA += buttonNine.Text;
            }
            else
            {
                sB += buttonNine.Text;
                fB = true;
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
                        textBox.AppendText(buttonZero.Text);
            if (!fA)
            {
                sA += buttonZero.Text;
            }
            else
            {
                sB += buttonZero.Text;
                fB = true;
            }
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

            if (size > 0 || fPoint)
            {
                if (!fA)
                {
                    sA += ",";
                    textBox.AppendText(",");
                    fPoint = true;
                }
                else
                {
                    sB += ",";
                    textBox.AppendText(",");
                    fPoint = true;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int size = textBox.Text.Length;

            if (size > 0)
            {
                textBox.Text = textBox.Text.Substring(0, size - 1);
                if (!fA)
                {
                    sA = textBox.Text = textBox.Text.Substring(0, size - 1);
                }
                else
                {
                    sB = textBox.Text = textBox.Text.Substring(0, size - 1);
                }
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {

        }
    }
}