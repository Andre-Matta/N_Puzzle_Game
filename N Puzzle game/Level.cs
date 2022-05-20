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
    public partial class Level : Form
    {
        public static int[] puzzle_1d_array;
        public static bool is_done = false;
        public Level()
        {
            InitializeComponent();
        }

        private void Level_Load(object sender, EventArgs e)
        {
            if (Main_Menu.Puzzle_dimention == 0)
                button1.Visible = false;
            else
                button1.Visible=true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert_Puzzle insert_Puzzle = new Insert_Puzzle();
            insert_Puzzle.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath;
            OpenFileDialog puzzle_from_file = new OpenFileDialog();
            puzzle_from_file.InitialDirectory = "c:\\";
            puzzle_from_file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            puzzle_from_file.FilterIndex = 2;
            puzzle_from_file.RestoreDirectory = true;

            if (puzzle_from_file.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = puzzle_from_file.FileName;

                //Read the contents of the file into a stream
                var fileStream = puzzle_from_file.OpenFile();
                StreamReader reader = new StreamReader(fileStream);

                int tmp = int.Parse(reader.ReadLine());
                if (Main_Menu.Puzzle_dimention == tmp || Main_Menu.Puzzle_dimention == 0)
                {
                    Main_Menu.Puzzle_dimention = tmp;
                    puzzle_1d_array = new int[Main_Menu.Puzzle_dimention * Main_Menu.Puzzle_dimention];

                    string s = reader.ReadLine();
                    if (s == "")
                    {
                        for (int i = 0; i < Main_Menu.Puzzle_dimention; i++)
                        {
                            string[] Parts = reader.ReadLine().Split(' ');
                            for (int j = 0; j < Main_Menu.Puzzle_dimention; j++)
                                puzzle_1d_array[Main_Menu.Puzzle_dimention * i + j] = int.Parse(Parts[j]);
                        }
                    }
                    else
                    {
                        string[] Parts = s.Split(' ');
                        for (int i = 0; i < Main_Menu.Puzzle_dimention; i++)
                        {
                            puzzle_1d_array[i] = int.Parse(Parts[i]);
                        }

                        for (int i = 1; i < Main_Menu.Puzzle_dimention; i++)
                        {
                            Parts = reader.ReadLine().Split(' ');
                            for (int j = 0; j < Main_Menu.Puzzle_dimention; j++)
                                puzzle_1d_array[Main_Menu.Puzzle_dimention * i + j] = int.Parse(Parts[j]);
                        }
                    }

                    if (Main_Menu.Puzzle_dimention == 3)
                    {
                        Puzzle_8 puzzle_8 = new Puzzle_8();
                        this.Hide();
                        puzzle_8.ShowDialog();
                        this.Close();
                    }
                    else if (Main_Menu.Puzzle_dimention == 4)
                    {
                        Puzzle_15 puzzle_15 = new Puzzle_15();
                        this.Hide();
                        puzzle_15.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Puzzle_N puzzle_N = new Puzzle_N();
                        this.Hide();
                        puzzle_N.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Choosen File isn't correct or\n"+
                        "given puzzle isn't same as puzzle in file.\n" +
                        "For Example: \n3\n3 2 5\n4 8 7\n0 1 6");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_Menu.Puzzle_dimention = 0;
            Main_Menu menu = new Main_Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
