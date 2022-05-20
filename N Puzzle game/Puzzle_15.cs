using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_Puzzle_game
{
    public partial class Puzzle_15 : Form
    {
        public int solving_moves_index = 0;
        public bool is_zero_clicked = false, is_button_clicked = false;
        public Button button;
        public int manual_moves = 0;

        public Puzzle_15()
        {
            InitializeComponent();
        }
       
        private void Puzzle_15_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            load_array_to_box(Level.puzzle_1d_array);
        }
        // manhattan button is clicked 
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            Program.Solve_puzzle("1", Main_Menu.Puzzle_dimention, Level.puzzle_1d_array);
            button21.Text = Program.min_number_of_moves.ToString();
            button24.Text = Program.total_number_of_moves.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            Program.Solve_puzzle("2", Main_Menu.Puzzle_dimention, Level.puzzle_1d_array);
            button21.Text = Program.min_number_of_moves.ToString();
            button24.Text = Program.total_number_of_moves.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_Menu menu = new Main_Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button22.Enabled = false;
            button23.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button5.BackColor = Color.Green;

                if (button5.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button5;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button6 || button == button9)
                {
                    button.Text = button5.Text;
                    button5.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                    MessageBox.Show("select a button next to the button you selected");

                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button6 || button == button9) && button5.Text == "")
                {
                    button5.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");

                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button6.BackColor = Color.Green;

                if (button6.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button6;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button5 || button == button7 || button == button10)
                {
                    button.Text = button6.Text;
                    button6.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button5 || button == button7 || button == button10) && button6.Text == "")
                {
                    button6.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button7.BackColor = Color.Green;

                if (button7.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button7;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button6 || button == button8 || button == button11)
                {
                    button.Text = button7.Text;
                    button7.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button6 || button == button8 || button == button11) && button7.Text == "")
                {
                    button7.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button8.BackColor = Color.Green;

                if (button8.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button8;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button7 || button == button12)
                {
                    button.Text = button8.Text;
                    button8.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button7 || button == button12) && button8.Text == "")
                {
                    button8.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button9.BackColor = Color.Green;

                if (button9.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button9;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button5 || button == button13 || button == button10)
                {
                    button.Text = button9.Text;
                    button9.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button5 || button == button13 || button == button10) && button9.Text == "")
                {
                    button9.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button10.BackColor = Color.Green;

                if (button10.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button10;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button9 || button == button11 || button == button6 || button == button14)
                {
                    button.Text = button10.Text;
                    button10.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button9 || button == button11 || button == button6 || button == button14) && button10.Text == "")
                {
                    button10.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button11.BackColor = Color.Green;

                if (button11.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button11;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button10 || button == button12 || button == button7 || button == button15)
                {
                    button.Text = button11.Text;
                    button11.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button10 || button == button12 || button == button7 || button == button15) && button11.Text == "")
                {
                    button11.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button12.BackColor = Color.Green;

                if (button12.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button12;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button11 || button == button8 || button == button16)
                {
                    button.Text = button12.Text;
                    button12.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button11 || button == button8 || button == button16) && button12.Text == "")
                {
                    button12.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button13.BackColor = Color.Green;

                if (button13.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button13;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button14 || button == button17 || button == button9)
                {
                    button.Text = button13.Text;
                    button13.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button14 || button == button17 || button == button9) && button13.Text == "")
                {
                    button13.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button14.BackColor = Color.Green;

                if (button14.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button14;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button13 || button == button15 || button == button18 || button == button10)
                {
                    button.Text = button14.Text;
                    button14.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button13 || button == button15 || button == button18 || button == button10) && button14.Text == "")
                {
                    button14.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button15.BackColor = Color.Green;

                if (button15.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button15;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button14 || button == button16 || button == button19 || button == button11)
                {
                    button.Text = button15.Text;
                    button15.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button14 || button == button16 || button == button19 || button == button11) && button15.Text == "")
                {
                    button15.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button16.BackColor = Color.Green;

                if (button16.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button16;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button15 || button == button12 || button == button20)
                {
                    button.Text = button16.Text;
                    button16.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button15 || button == button12 || button == button20) && button16.Text == "")
                {
                    button16.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();

                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button17.BackColor = Color.Green;

                if (button17.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button17;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button13 || button == button18)
                {
                    button.Text = button17.Text;
                    button17.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                    MessageBox.Show("select a button next to the button you selected");

                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button13 || button == button18) && button17.Text == "")
                {
                    button17.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");

                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button18.BackColor = Color.Green;

                if (button18.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button18;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button17 || button == button19 || button == button14)
                {
                    button.Text = button18.Text;
                    button18.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button17 || button == button19 || button == button14) && button18.Text == "")
                {
                    button18.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button19.BackColor = Color.Green;

                if (button19.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button19;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button18 || button == button20 || button == button15)
                {
                    button.Text = button19.Text;
                    button19.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button18 || button == button20 || button == button15) && button19.Text == "")
                {
                    button19.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!is_button_clicked && !is_zero_clicked)
            {
                button20.BackColor = Color.Green;

                if (button20.Text == "")
                    is_zero_clicked = true;
                else
                    is_button_clicked = true;

                button = button20;
            }
            else if (!is_button_clicked && is_zero_clicked)
            {
                if (button == button19 || button == button16)
                {
                    button.Text = button20.Text;
                    button20.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            else if (is_button_clicked && !is_zero_clicked)
            {
                if ((button == button19 || button == button16) && button20.Text == "")
                {
                    button20.Text = button.Text;
                    button.Text = "";
                    manual_moves++;
                    button21.Text = manual_moves.ToString();
                }
                else
                {
                    MessageBox.Show("select a button next to the button you selected or blank isn't selected");
                }
                button.BackColor = Color.Gainsboro;
                is_button_clicked = false;
                is_zero_clicked = false;
            }
            check_if_manual_solved();
        }

        private void button23_Click(object sender, EventArgs e)
        {
              if (solving_moves_index < Program.Solving_Moves.Count)
            {
                load_array_to_box(Program.Solving_Moves[solving_moves_index]);
                solving_moves_index++;
            }

            if (button5.Text == "")
                button5.BackColor = Color.Green;
            else
                button5.BackColor = Color.Gainsboro;

            if (button6.Text == "")
                button6.BackColor = Color.Green;
            else
                button6.BackColor = Color.Gainsboro;

            if (button7.Text == "")
                button7.BackColor = Color.Green;
            else
                button7.BackColor = Color.Gainsboro;

            if (button8.Text == "")
                button8.BackColor = Color.Green;
            else
                button8.BackColor = Color.Gainsboro;

            if (button9.Text == "")
                button9.BackColor = Color.Green;
            else
                button9.BackColor = Color.Gainsboro;

            if (button10.Text == "")
                button10.BackColor = Color.Green;
            else
                button10.BackColor = Color.Gainsboro;

            if (button11.Text == "")
                button11.BackColor = Color.Green;
            else
                button11.BackColor = Color.Gainsboro;

            if (button12.Text == "")
                button12.BackColor = Color.Green;
            else
                button12.BackColor = Color.Gainsboro;

            if (button13.Text == "")
                button13.BackColor = Color.Green;
            else
                button13.BackColor = Color.Gainsboro;

            if (button14.Text == "")
                button14.BackColor = Color.Green;
            else
                button14.BackColor = Color.Gainsboro;

            if (button15.Text == "")
                button15.BackColor = Color.Green;
            else
                button15.BackColor = Color.Gainsboro;

            if (button16.Text == "")
                button16.BackColor = Color.Green;
            else
                button16.BackColor = Color.Gainsboro;

            if (button17.Text == "")
                button17.BackColor = Color.Green;
            else
                button17.BackColor = Color.Gainsboro;

            if (button18.Text == "")
                button18.BackColor = Color.Green;
            else
                button18.BackColor = Color.Gainsboro;

            if (button19.Text == "")
                button19.BackColor = Color.Green;
            else
                button19.BackColor = Color.Gainsboro;

            if (button20.Text == "")
                button20.BackColor = Color.Green;
            else
                button20.BackColor = Color.Gainsboro;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (solving_moves_index != 0)
            {
                solving_moves_index--;
                load_array_to_box(Program.Solving_Moves[solving_moves_index]);

            if (button5.Text == "")
                button5.BackColor = Color.Green;
            else
                button5.BackColor = Color.Gainsboro;

            if (button6.Text == "")
                button6.BackColor = Color.Green;
            else
                button6.BackColor = Color.Gainsboro;

            if (button7.Text == "")
                button7.BackColor = Color.Green;
            else
                button7.BackColor = Color.Gainsboro;

            if (button8.Text == "")
                button8.BackColor = Color.Green;
            else
                button8.BackColor = Color.Gainsboro;

            if (button9.Text == "")
                button9.BackColor = Color.Green;
            else
                button9.BackColor = Color.Gainsboro;

            if (button10.Text == "")
                button10.BackColor = Color.Green;
            else
                button10.BackColor = Color.Gainsboro;

            if (button11.Text == "")
                button11.BackColor = Color.Green;
            else
                button11.BackColor = Color.Gainsboro;

            if (button12.Text == "")
                button12.BackColor = Color.Green;
            else
                button12.BackColor = Color.Gainsboro;

            if (button13.Text == "")
                button13.BackColor = Color.Green;
            else
                button13.BackColor = Color.Gainsboro;

            if (button14.Text == "")
                button14.BackColor = Color.Green;
            else
                button14.BackColor = Color.Gainsboro;

            if (button15.Text == "")
                button15.BackColor = Color.Green;
            else
                button15.BackColor = Color.Gainsboro;

            if (button16.Text == "")
                button16.BackColor = Color.Green;
            else
                button16.BackColor = Color.Gainsboro;

            if (button17.Text == "")
                button17.BackColor = Color.Green;
            else
                button17.BackColor = Color.Gainsboro;

            if (button18.Text == "")
                button18.BackColor = Color.Green;
            else
                button18.BackColor = Color.Gainsboro;

            if (button19.Text == "")
                button19.BackColor = Color.Green;
            else
                button19.BackColor = Color.Gainsboro;

            if (button20.Text == "")
                button20.BackColor = Color.Green;
            else
                button20.BackColor = Color.Gainsboro;
            }
        }

        private void load_array_to_box(int[] array)
        {
            if (array[0] != 0)
                button5.Text = array[0].ToString();
            else
                button5.Text = "";
            if (array[1] != 0)
                button6.Text = array[1].ToString();
            else
                button6.Text = "";

            if (array[2] != 0)
                button7.Text = array[2].ToString();
            else
                button7.Text = "";

            if (array[3] != 0)
                button8.Text = array[3].ToString();
            else
                button8.Text = "";

            if (array[4] != 0)
                button9.Text = array[4].ToString();
            else
                button9.Text = "";

            if (array[5] != 0)
                button10.Text = array[5].ToString();
            else
                button10.Text = "";

            if (array[6] != 0)
                button11.Text = array[6].ToString();
            else
                button11.Text = "";

            if (array[7] != 0)
                button12.Text = array[7].ToString();
            else
                button12.Text = "";

            if (array[8] != 0)
                button13.Text = array[8].ToString();
            else
                button13.Text = "";

            if (array[9] != 0)
                button14.Text = array[9].ToString();
            else
                button14.Text = "";

            if (array[10] != 0)
                button15.Text = array[10].ToString();
            else
                button15.Text = "";

            if (array[11] != 0)
                button16.Text = array[11].ToString();
            else
                button16.Text = "";

            if (array[12] != 0)
                button17.Text = array[12].ToString();
            else
                button17.Text = "";

            if (array[13] != 0)
                button18.Text = array[13].ToString();
            else
                button18.Text = "";

            if (array[14] != 0)
                button19.Text = array[14].ToString();
            else
                button19.Text = "";

            if (array[15] != 0)
                button20.Text = array[15].ToString();
            else
                button20.Text = "";
        }

        private void check_if_manual_solved()
        {
            int[] tmp = new int[Main_Menu.Puzzle_dimention * Main_Menu.Puzzle_dimention];

            if (button5.Text != "")
                tmp[0] = int.Parse(button5.Text);
            else
                tmp[0] = 0;

            if (button6.Text != "")
                tmp[1] = int.Parse(button6.Text);
            else
                tmp[1] = 0;

            if (button7.Text != "")
                tmp[2] = int.Parse(button7.Text);
            else
                tmp[2] = 0;

            if (button8.Text != "")
                tmp[3] = int.Parse(button8.Text);
            else
                tmp[3] = 0;

            if (button9.Text != "")
                tmp[4] = int.Parse(button9.Text);
            else
                tmp[4] = 0;

            if (button10.Text != "")
                tmp[5] = int.Parse(button10.Text);
            else
                tmp[5] = 0;

            if (button11.Text != "")
                tmp[6] = int.Parse(button11.Text);
            else
                tmp[6] = 0;

            if (button12.Text != "")
                tmp[7] = int.Parse(button12.Text);
            else
                tmp[7] = 0;

            if (button13.Text != "")
                tmp[8] = int.Parse(button13.Text);
            else
                tmp[8] = 0;

            if (button14.Text != "")
                tmp[9] = int.Parse(button14.Text);
            else
                tmp[9] = 0;

            if (button15.Text != "")
                tmp[10] = int.Parse(button15.Text);
            else
                tmp[10] = 0;

            if (button16.Text != "")
                tmp[11] = int.Parse(button16.Text);
            else
                tmp[11] = 0;

            if (button17.Text != "")
                tmp[12] = int.Parse(button17.Text);
            else
                tmp[12] = 0;

            if (button18.Text != "")
                tmp[13] = int.Parse(button18.Text);
            else
                tmp[13] = 0;

            if (button19.Text != "")
                tmp[14] = int.Parse(button19.Text);
            else
                tmp[14] = 0;

            if (button20.Text != "")
                tmp[15] = int.Parse(button20.Text);
            else
                tmp[15] = 0;

            Node tmp_node = new Node(tmp, Main_Menu.Puzzle_dimention, null, 0);
            tmp_node.calculate_manhattan_distance();
            if (tmp_node.heuristic_value == 0)
            {
                MessageBox.Show("Congratulations!! :)");
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
            }
        }

    }
}
