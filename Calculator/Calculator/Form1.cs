using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CurrentState = state.nonstate;

        }

        #region variables

        state CurrentState;
        string memory;
        enum state
        {
            substraction,
            addition,
            multiplication,
            division,
            nonstate
        }
        #endregion

        #region Equally

        private void EquallyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentState == state.addition)
                {
                    CurrentState = state.nonstate;
                    double memory2 = double.Parse(textBox1.Text);
                    textBox1.Text = (double.Parse(memory) + memory2).ToString();
                    textBox1.Focus();
                    label1.Text += memory2.ToString() + " =";
                }
               
                if (CurrentState == state.multiplication)
                {
                    CurrentState = state.nonstate;
                    double memory2 = double.Parse(textBox1.Text);
                    textBox1.Text = (double.Parse(memory) * memory2).ToString();
                    textBox1.Focus();
                    label1.Text += memory2.ToString() + " =";
                }
                if (CurrentState == state.substraction)
                {
                    CurrentState = state.nonstate;
                    double memory2 = double.Parse(textBox1.Text);
                    textBox1.Text = (double.Parse(memory) - memory2).ToString();
                    textBox1.Focus();
                    label1.Text += memory2.ToString() + " =";
                }
                 if (CurrentState == state.division)
                {
                    CurrentState = state.nonstate;
                    double memory2 = double.Parse(textBox1.Text);
                    textBox1.Text = (double.Parse(memory) / memory2).ToString();
                    textBox1.Focus();
                    label1.Text += memory2.ToString() + " =";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try input incorrect data");
            }
        }
        #endregion

        #region Arifmetical operations

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.addition;
                memory = textBox1.Text;
                textBox1.Text = "";
                label1.Text = memory.ToString() + " +";
            }
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.multiplication;
                memory = textBox1.Text;
                textBox1.Text = "";
                label1.Text = memory.ToString() + " *";
            }
        }

        private void SubstractionButton_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.substraction;
                memory = textBox1.Text;
                textBox1.Text = "";
                label1.Text = memory.ToString() + " -";
            }
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.division;
                memory = textBox1.Text;
                textBox1.Text = "";
                label1.Text = memory.ToString() + " /";
            }
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            memory = textBox1.Text;
            textBox1.Text = (double.Parse(memory) * double.Parse(memory)).ToString();
            label1.Text = memory.ToString() + "*" + memory.ToString() + "=";
        }

        #endregion

        #region Buttons
        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + 0;
                textBox1.Focus();
            }
        }
            private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + 1;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + 2;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + 3;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + 4;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + 5;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + 6;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + 7;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + 8;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + 9;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf('.') == -1)
            {
                textBox1.Text += ".";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            CurrentState = state.nonstate;
            memory = "";
            label1.Text = "";
        }

        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO percent
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}