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
    public partial class Puzzle_N : Form
    {
        public Puzzle_N()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            Program.Solve_puzzle("1", Main_Menu.Puzzle_dimention, Level.puzzle_1d_array);
            button21.Text = Program.min_number_of_moves.ToString();
            button4.Text = Program.total_number_of_moves.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            Program.Solve_puzzle("2", Main_Menu.Puzzle_dimention, Level.puzzle_1d_array);
            button21.Text = Program.min_number_of_moves.ToString();
            button4.Text = Program.total_number_of_moves.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_Menu menu = new Main_Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
