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
    public partial class Insert_Puzzle : Form
    {
        public int [] puzzle_1d_tmp = new int [Main_Menu.Puzzle_dimention*Main_Menu.Puzzle_dimention];
        public bool[]check_puzzle = new bool[Main_Menu.Puzzle_dimention*Main_Menu.Puzzle_dimention];
        public bool is_done = true;

        public Insert_Puzzle()
        {
            InitializeComponent();
        }
       
        private void Insert_Puzzle_Load(object sender, EventArgs e)
        {
            if (Main_Menu.Puzzle_dimention == 3)
            {
                textBox4.Visible = false;
                textBox8.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
                textBox16.Visible = false;
                textBox4.Enabled = false;
                textBox8.Enabled = false;
                textBox12.Enabled = false;
                textBox13.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox16.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level.puzzle_1d_array = new int[Main_Menu.Puzzle_dimention*Main_Menu.Puzzle_dimention];
            check_puzzle = new bool[Main_Menu.Puzzle_dimention * Main_Menu.Puzzle_dimention];
            is_done = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            is_done = true;
            for (int i = 0; i < Main_Menu.Puzzle_dimention*Main_Menu.Puzzle_dimention; i++)
            {
                if (!check_puzzle[i])
                    is_done = false;
            }
            if (is_done)
            {
                Level.puzzle_1d_array = puzzle_1d_tmp;
                Level.is_done = is_done;
                this.Hide();
                if (Main_Menu.Puzzle_dimention == 3)
                {
                    Puzzle_8 puzzle_8 = new Puzzle_8();
                    puzzle_8.ShowDialog();
                }
                else
                {
                    Puzzle_15 puzzle_15 = new Puzzle_15();
                    puzzle_15.ShowDialog();
                }
                this.Close();
            }
            else
                MessageBox.Show("There are empty boxes.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Menu menu = new Main_Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Main_Menu.Puzzle_dimention == 3 && int.Parse(textBox1.Text) <= 8 && int.Parse(textBox1.Text) >= 0)
                {
                    if (!check_puzzle[int.Parse(textBox1.Text)])
                    {
                        check_puzzle[int.Parse(textBox1.Text)] = true;
                        puzzle_1d_tmp[0] = int.Parse(textBox1.Text);
                    }
                    else
                    {
                        textBox1.Clear();
                        MessageBox.Show("Number Already Entered");
                    }
                }
                else if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox1.Text) <= 15 && int.Parse(textBox1.Text) >= 0)
                {
                    if (!check_puzzle[int.Parse(textBox1.Text)])
                    {
                        check_puzzle[int.Parse(textBox1.Text)] = true;
                        puzzle_1d_tmp[0] = int.Parse(textBox1.Text);
                    }
                    else
                    {
                        textBox1.Clear();
                        MessageBox.Show("Number Already Entered");
                    }
                }
                else
                {
                    textBox1.Clear();
                    MessageBox.Show("Wrong Entry");
                }
            }
           
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {

            if (Main_Menu.Puzzle_dimention == 3 && int.Parse(textBox2.Text) <= 8 && int.Parse(textBox2.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox2.Text)])
                {
                    check_puzzle[int.Parse(textBox2.Text)] = true;
                    puzzle_1d_tmp[1] = int.Parse(textBox2.Text);
                }
                else
                {
                    textBox2.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox2.Text) <= 15 && int.Parse(textBox2.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox2.Text)])
                {
                    check_puzzle[int.Parse(textBox2.Text)] = true;
                    puzzle_1d_tmp[1] = int.Parse(textBox2.Text);
                }
                else
                {
                    textBox2.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox2.Clear();
                MessageBox.Show("Wrong Entry");
            }
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {

            if (Main_Menu.Puzzle_dimention == 3 && int.Parse(textBox3.Text) <= 8 && int.Parse(textBox3.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox3.Text)])
                {
                    check_puzzle[int.Parse(textBox3.Text)] = true;
                    puzzle_1d_tmp[2] = int.Parse(textBox3.Text);
                }
                else
                {
                    textBox3.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox3.Text) <= 15 && int.Parse(textBox3.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox3.Text)])
                {
                    check_puzzle[int.Parse(textBox3.Text)] = true;
                    puzzle_1d_tmp[2] = int.Parse(textBox3.Text);
                }
                else
                {
                    textBox3.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox3.Clear();
                MessageBox.Show("Wrong Entry");
            }
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {

            if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox4.Text) <= 15 && int.Parse(textBox4.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox4.Text)])
                {
                    check_puzzle[int.Parse(textBox4.Text)] = true;
                    puzzle_1d_tmp[3] = int.Parse(textBox4.Text);
                }
                else
                {
                    textBox4.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox4.Clear();
                MessageBox.Show("Wrong Entry");
            }
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {

            if (Main_Menu.Puzzle_dimention == 3 && int.Parse(textBox5.Text) <= 8 && int.Parse(textBox5.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox5.Text)])
                {
                    check_puzzle[int.Parse(textBox5.Text)] = true;
                    puzzle_1d_tmp[3] = int.Parse(textBox5.Text);
                }
                else
                {
                    textBox5.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox5.Text) <= 15 && int.Parse(textBox5.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox5.Text)])
                {
                    check_puzzle[int.Parse(textBox5.Text)] = true;
                    puzzle_1d_tmp[4] = int.Parse(textBox5.Text);
                }
                else
                {
                    textBox5.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox5.Clear();
                MessageBox.Show("Wrong Entry");
            }
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {

            if (Main_Menu.Puzzle_dimention == 3 && int.Parse(textBox6.Text) <= 8 && int.Parse(textBox6.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox6.Text)])
                {
                    check_puzzle[int.Parse(textBox6.Text)] = true;
                    puzzle_1d_tmp[4] = int.Parse(textBox6.Text);
                }
                else
                {
                    textBox6.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox6.Text) <= 15 && int.Parse(textBox6.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox6.Text)])
                {
                    check_puzzle[int.Parse(textBox6.Text)] = true;
                    puzzle_1d_tmp[5] = int.Parse(textBox6.Text);
                }
                else
                {
                    textBox6.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox6.Clear();
                MessageBox.Show("Wrong Entry");
            }
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {

            if (Main_Menu.Puzzle_dimention == 3 && int.Parse(textBox7.Text) <= 8 && int.Parse(textBox7.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox7.Text)])
                {
                    check_puzzle[int.Parse(textBox7.Text)] = true;
                    puzzle_1d_tmp[5] = int.Parse(textBox7.Text);
                }
                else
                {
                    textBox7.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox7.Text) <= 15 && int.Parse(textBox7.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox7.Text)])
                {
                    check_puzzle[int.Parse(textBox7.Text)] = true;
                    puzzle_1d_tmp[6] = int.Parse(textBox7.Text);
                }
                else
                {
                    textBox7.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox7.Clear();
                MessageBox.Show("Wrong Entry");
            }
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {

            if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox8.Text) <= 15 && int.Parse(textBox8.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox8.Text)])
                {
                    check_puzzle[int.Parse(textBox8.Text)] = true;
                    puzzle_1d_tmp[7] = int.Parse(textBox8.Text);
                }
                else
                {
                    textBox8.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox8.Clear();
                MessageBox.Show("Wrong Entry");
            }
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {

            if (Main_Menu.Puzzle_dimention == 3 && int.Parse(textBox9.Text) <= 8 && int.Parse(textBox9.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox9.Text)])
                {
                    check_puzzle[int.Parse(textBox9.Text)] = true;
                    puzzle_1d_tmp[6] = int.Parse(textBox9.Text);
                }
                else
                {
                    textBox9.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox9.Text) <= 15 && int.Parse(textBox9.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox9.Text)])
                {
                    check_puzzle[int.Parse(textBox9.Text)] = true;
                    puzzle_1d_tmp[8] = int.Parse(textBox9.Text);
                }
                else
                {
                    textBox9.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox9.Clear();
                MessageBox.Show("Wrong Entry");
            }
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {

            if (Main_Menu.Puzzle_dimention == 3 && int.Parse(textBox10.Text) <= 8 && int.Parse(textBox10.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox10.Text)])
                {
                    check_puzzle[int.Parse(textBox10.Text)] = true;
                    puzzle_1d_tmp[7] = int.Parse(textBox10.Text);
                }
                else
                {
                    textBox10.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox10.Text) <= 15 && int.Parse(textBox10.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox10.Text)])
                {
                    check_puzzle[int.Parse(textBox10.Text)] = true;
                    puzzle_1d_tmp[9] = int.Parse(textBox10.Text);
                }
                else
                {
                    textBox10.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox10.Clear();
                MessageBox.Show("Wrong Entry");
            }
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
            if (Main_Menu.Puzzle_dimention == 3 && int.Parse(textBox11.Text) <= 8 && int.Parse(textBox11.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox11.Text)])
                {
                    check_puzzle[int.Parse(textBox11.Text)] = true;
                    puzzle_1d_tmp[8] = int.Parse(textBox11.Text);
                }
                else
                {
                    textBox11.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox11.Text) <= 15 && int.Parse(textBox11.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox11.Text)])
                {
                    check_puzzle[int.Parse(textBox11.Text)] = true;
                    puzzle_1d_tmp[10] = int.Parse(textBox11.Text);
                }
                else
                {
                    textBox11.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox11.Clear();
                MessageBox.Show("Wrong Entry");
            }

            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (textBox12.Text != "")
            {

            if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox1.Text) <= 15 && int.Parse(textBox12.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox12.Text)])
                {
                    check_puzzle[int.Parse(textBox12.Text)] = true;
                    puzzle_1d_tmp[11] = int.Parse(textBox12.Text);
                }
                else
                {
                    textBox12.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox12.Clear();
                MessageBox.Show("Wrong Entry");
            }
            }
        }

        private void textBox13_Leave(object sender, EventArgs e)
        {
            if (textBox13.Text != "")
            {
            if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox13.Text) <= 15 && int.Parse(textBox13.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox13.Text)])
                {
                    check_puzzle[int.Parse(textBox13.Text)] = true;
                    puzzle_1d_tmp[12] = int.Parse(textBox13.Text);
                }
                else
                {
                    textBox13.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox13.Clear();
                MessageBox.Show("Wrong Entry");
            }

            }
        }

        private void textBox14_Leave(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
            if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox14.Text) <= 15 && int.Parse(textBox14.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox14.Text)])
                {
                    check_puzzle[int.Parse(textBox14.Text)] = true;
                    puzzle_1d_tmp[13] = int.Parse(textBox14.Text);
                }
                else
                {
                    textBox14.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox14.Clear();
                MessageBox.Show("Wrong Entry");
            }

            }
        }

        private void textBox15_Leave(object sender, EventArgs e)
        {
            if (textBox15.Text != "")
            {

            if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox15.Text) <= 15 && int.Parse(textBox15.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox15.Text)])
                {
                    check_puzzle[int.Parse(textBox15.Text)] = true;
                    puzzle_1d_tmp[14] = int.Parse(textBox15.Text);
                }
                else
                {
                    textBox15.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox15.Clear();
                MessageBox.Show("Wrong Entry");
            }
            }
        }

        private void textBox16_Leave(object sender, EventArgs e)
        {
            if (textBox16.Text != "")
            {

            if (Main_Menu.Puzzle_dimention == 4 && int.Parse(textBox16.Text) <= 15 && int.Parse(textBox16.Text) >= 0)
            {
                if (!check_puzzle[int.Parse(textBox16.Text)])
                {
                    check_puzzle[int.Parse(textBox16.Text)] = true;
                    puzzle_1d_tmp[15] = int.Parse(textBox16.Text);
                }
                else
                {
                    textBox16.Clear();
                    MessageBox.Show("Number Already Entered");
                }
            }
            else
            {
                textBox16.Clear();
                MessageBox.Show("Wrong Entry");
            }
            }
        }
    }
}
