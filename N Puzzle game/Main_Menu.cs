namespace N_Puzzle_game
{
    public partial class Main_Menu : Form
    {
        public static int Puzzle_dimention = 0;
        public Main_Menu()
        {
            InitializeComponent();
        }
        private void Main_Menu_Load(object sender, EventArgs e)
        {
            Puzzle_dimention = 0;
            Program.priorityQueue.Clear();
            Program.Solving_Moves.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Puzzle_dimention = 3;
            Level level = new Level();
            this.Hide();
            level.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Puzzle_dimention = 4;
            Level level = new Level();
            this.Hide();
            level.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Level level = new Level();
            this.Hide();
            level.ShowDialog();
            this.Close();
        }

    }
}