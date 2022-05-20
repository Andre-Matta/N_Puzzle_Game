using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Puzzle_game
{
    class Node
    {
        public int[] puzzle_1d;
        public int puzzle_dimension;
        public int heuristic_value = 0;
        public int cost_so_far;
        public int zero_pos;
        public Node parent;

        public Node(int[] puzzle_1d, int puzzle_dimension, Node parent, int cost_so_far)
        {
            this.puzzle_1d = new int[puzzle_dimension * puzzle_dimension];
            puzzle_1d.CopyTo(this.puzzle_1d, 0);
            this.puzzle_dimension = puzzle_dimension;
            this.cost_so_far = cost_so_far;
            this.parent = parent;
        }

        public void calculate_manhattan_distance()
        {
            int distance = 0;
            int puzzle_size = puzzle_dimension * puzzle_dimension;
            for (int i = 0; i < puzzle_size; i++)
            {
                int v = puzzle_1d[i];
                if (v == 0)
                {
                    continue;
                }
                v = v - 1;

                int goal_x = v % puzzle_dimension;
                int goal_y = v / puzzle_dimension;

                int x = i % puzzle_dimension;
                int y = i / puzzle_dimension;

                int manhatten_cost = Math.Abs(x - goal_x) + Math.Abs(y - goal_y);
                distance += manhatten_cost;

            }
            heuristic_value = distance;
        }

        public void calculate_hamming_distance()
        {
            for (int i = 0; i < puzzle_dimension * puzzle_dimension; i++)
            {
                if (puzzle_1d[i] != i + 1 && puzzle_1d[i] != 0)
                    heuristic_value++;
            }
        }
        
        public int priority()
        {
            return heuristic_value + cost_so_far;
        }
        
        public void modify_manhattan_distance(int old_index, int new_index)
        {
            int v = puzzle_1d[old_index];
            v = v - 1;

            int goal_x = v % puzzle_dimension;
            int goal_y = v / puzzle_dimension;

            int x = new_index % puzzle_dimension;
            int y = new_index / puzzle_dimension;

            int manhatten_cost = Math.Abs(x - goal_x) + Math.Abs(y - goal_y);
            heuristic_value -= manhatten_cost;

            v = puzzle_1d[old_index];
            v = v - 1;

            goal_x = v % puzzle_dimension;
            goal_y = v / puzzle_dimension;

            x = old_index % puzzle_dimension;
            y = old_index / puzzle_dimension;

            manhatten_cost = Math.Abs(x - goal_x) + Math.Abs(y - goal_y);
            heuristic_value += manhatten_cost;
        }

        public void modify_hamming_distance(int old_index , int new_index)
        {
            if (puzzle_1d[old_index] == old_index + 1)
            {
                heuristic_value--;
            }
            else if (puzzle_1d[old_index] == new_index + 1)
            {
                heuristic_value++;
            }
        }

    }
}
