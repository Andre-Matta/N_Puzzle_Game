using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace N_Puzzle_game
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main_Menu());
        }

        public static PriorityQueue<Node, int> priorityQueue = new PriorityQueue<Node, int>(/*new DataComparer()*/);
        public static int min_number_of_moves;
        public static long total_number_of_moves = 0;
        public static string Hamming_or_Manhattan;
        public static List<int[]> Solving_Moves = new List<int[]>();
        public static Stopwatch stopwatch = new Stopwatch();

        public static bool is_puzzle_solvable(int puzzle_dimension, int[] puzzle_1d_array)
        {
            int no_of_inversions = 0;
            int blank_space_pos = 0;
            for (int i = 0; i < puzzle_dimension * puzzle_dimension; i++)
            {
                if (puzzle_1d_array[i] == 0)
                {
                    blank_space_pos = i / puzzle_dimension + 1;
                    continue;
                }
                for (int j = i + 1; j < puzzle_dimension * puzzle_dimension; j++)
                {
                    if (puzzle_1d_array[i] > puzzle_1d_array[j] && puzzle_1d_array[j] != 0)
                    {
                        no_of_inversions++;
                    }
                }

            }
            //if N is even
            if (puzzle_dimension % 2 == 0)
            {
                if (no_of_inversions % 2 == 0 && (puzzle_dimension - blank_space_pos) % 2 == 0 ||
                    no_of_inversions % 2 != 0 && (puzzle_dimension - blank_space_pos) % 2 != 0)
                {
                    return true;
                }

            }
            //if N is odd
            else
            {
                if (no_of_inversions % 2 == 0)
                {
                    return true;
                }
            }


            return false;
        }

        public static Node A_Star_Search(Node node)
        {
            total_number_of_moves = 0;
            Node tmp_node = new Node(node.puzzle_1d, node.puzzle_dimension, node, node.cost_so_far);

            while (node.heuristic_value != 0)
            {
                total_number_of_moves++;
                if (node.heuristic_value == 0)
                {
                    return node;
                }
                Node node1;

                if (total_number_of_moves > 30000000 && Hamming_or_Manhattan == "2")
                {
                    MessageBox.Show("Puzzle is not solvable with hamming distance");
                    break;
                }

                // is up node 
                if (node.zero_pos - node.puzzle_dimension >= 0)
                {
                    tmp_node.parent = node;
                    tmp_node.zero_pos = node.zero_pos - node.puzzle_dimension;
                    tmp_node.cost_so_far = node.cost_so_far + 1;

                    if (tmp_node.cost_so_far < 2 ||
                        (tmp_node.cost_so_far >= 2 && tmp_node.zero_pos != tmp_node.parent.parent.zero_pos))
                    {

                        node1 = new Node(node.puzzle_1d, node.puzzle_dimension, node, node.cost_so_far + 1);
                        node1.puzzle_1d[node.zero_pos] = node1.puzzle_1d[node.zero_pos - node.puzzle_dimension];
                        node1.puzzle_1d[node.zero_pos - node.puzzle_dimension] = 0;
                        node1.zero_pos = node.zero_pos - node.puzzle_dimension;
                        node1.heuristic_value = node.heuristic_value;

                        if (Hamming_or_Manhattan == "1")
                            node1.modify_manhattan_distance(node.zero_pos, node1.zero_pos);
                        else if (Hamming_or_Manhattan == "2")
                            node1.modify_hamming_distance(node.zero_pos, node1.zero_pos);

                        priorityQueue.Enqueue(node1, node1.priority());
                    }
                }

                // is down node
                if ((node.zero_pos + node.puzzle_dimension) < (node.puzzle_dimension * node.puzzle_dimension))
                {
                    tmp_node.parent = node;
                    tmp_node.zero_pos = node.zero_pos + node.puzzle_dimension;
                    tmp_node.cost_so_far = node.cost_so_far + 1;

                    if (tmp_node.cost_so_far < 2 ||
                       (tmp_node.cost_so_far >= 2 && tmp_node.zero_pos != tmp_node.parent.parent.zero_pos))
                    {


                        node1 = new Node(node.puzzle_1d, node.puzzle_dimension, node, node.cost_so_far + 1);
                        node1.puzzle_1d[node.zero_pos] = node1.puzzle_1d[node.zero_pos + node.puzzle_dimension];
                        node1.puzzle_1d[node.zero_pos + node.puzzle_dimension] = 0;
                        node1.zero_pos = node.zero_pos + node.puzzle_dimension;
                        node1.heuristic_value = node.heuristic_value;

                        if (Hamming_or_Manhattan == "1")
                            node1.modify_manhattan_distance(node.zero_pos, node1.zero_pos);
                        else if (Hamming_or_Manhattan == "2")
                            node1.modify_hamming_distance(node.zero_pos, node1.zero_pos);

                        priorityQueue.Enqueue(node1, node1.priority());
                    }
                }

                // is right node
                if ((node.zero_pos % node.puzzle_dimension) != (node.puzzle_dimension - 1))
                {

                    tmp_node.parent = node;
                    tmp_node.zero_pos = node.zero_pos + 1;
                    tmp_node.cost_so_far = node.cost_so_far + 1;

                    if (tmp_node.cost_so_far < 2 ||
                       (tmp_node.cost_so_far >= 2 && tmp_node.zero_pos != tmp_node.parent.parent.zero_pos))
                    {

                        node1 = new Node(node.puzzle_1d, node.puzzle_dimension, node, node.cost_so_far + 1);
                    node1.puzzle_1d[node.zero_pos] = node1.puzzle_1d[node.zero_pos + 1];
                    node1.puzzle_1d[node.zero_pos + 1] = 0;
                    node1.zero_pos = node.zero_pos + 1;
                    node1.heuristic_value = node.heuristic_value;

                        if (Hamming_or_Manhattan == "1")
                            node1.modify_manhattan_distance(node.zero_pos, node1.zero_pos);
                        else if (Hamming_or_Manhattan == "2")
                            node1.modify_hamming_distance(node.zero_pos, node1.zero_pos);
                        priorityQueue.Enqueue(node1, node1.priority());
                    }
                }

                // is left node
                if ((node.zero_pos % node.puzzle_dimension) != 0)
                {
                    tmp_node.parent = node;
                    tmp_node.zero_pos = node.zero_pos - 1;
                    tmp_node.cost_so_far = node.cost_so_far + 1;

                    if (tmp_node.cost_so_far < 2 ||
                       (tmp_node.cost_so_far >= 2 && tmp_node.zero_pos != tmp_node.parent.parent.zero_pos))
                    {

                        node1 = new Node(node.puzzle_1d, node.puzzle_dimension, node, node.cost_so_far + 1);
                    node1.puzzle_1d[node.zero_pos] = node1.puzzle_1d[node.zero_pos - 1];
                    node1.puzzle_1d[node.zero_pos - 1] = 0;
                    node1.zero_pos = node.zero_pos - 1;
                    node1.heuristic_value = node.heuristic_value;

                        if (Hamming_or_Manhattan == "1")
                            node1.modify_manhattan_distance(node.zero_pos, node1.zero_pos);
                        else if (Hamming_or_Manhattan == "2")
                            node1.modify_hamming_distance(node.zero_pos, node1.zero_pos);

                        priorityQueue.Enqueue(node1, node1.priority());
                    }

                }

                node = priorityQueue.Dequeue();
            }
            return (node);
        }

        public static void Solve_puzzle(string h_or_m, int puzzle_dimension, int[] puzzle_1d_array)
        {
            Hamming_or_Manhattan = h_or_m;
            min_number_of_moves = 0;
            if (is_puzzle_solvable(puzzle_dimension, puzzle_1d_array))
            {
                Node root = new Node(puzzle_1d_array, puzzle_dimension, null, 0);
                if (Hamming_or_Manhattan == "1")
                    root.calculate_manhattan_distance();
                else if (Hamming_or_Manhattan == "2")
                    root.calculate_hamming_distance();
                priorityQueue.Enqueue(root, root.priority());

                for (int i = 0; i < puzzle_dimension * puzzle_dimension; i++)
                {
                    if (root.puzzle_1d[i] == 0)
                    {
                        root.zero_pos = i;
                    }
                }

                stopwatch.Start();
                Node goal = A_Star_Search(priorityQueue.Dequeue());
                stopwatch.Stop();
                MessageBox.Show("time taken to solve the puzzle = " + stopwatch.Elapsed);
                stopwatch.Reset();


                while (goal.parent != null)
                {
                    Solving_Moves.Insert(0, goal.puzzle_1d);
                    goal = goal.parent;
                    min_number_of_moves++;
                }
                Solving_Moves.Insert(0, goal.puzzle_1d);
            }
            else
            {
                MessageBox.Show("Puzzle is not Solvable");
            }

        }

    }

    /*    public class DataComparer : IComparer<int>
        {
            public int Compare(int a, int b)
            {
                if (a < b)
                {
                    return -1;
                }
                if (a >= b)
                {
                    return 1;
                }
                return 0;
            }
        }*/

}