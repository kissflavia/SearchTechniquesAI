using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
		// Initial values of 
		// Aplha and Beta 
		static int MAX = 1000;
		static int MIN = -1000;
		static public int[] x = new int[15];
		public static int poz;

		// Returns optimal value for 
		// current player (Initially called 
		// for root and maximizer) 
		public static int minimax(int depth, int nodeIndex,
						Boolean maximizingPlayer,
						int[] values, int alpha,
						int beta)
		{
			// Terminating condition. i.e 
			// leaf node is reached 
			if (depth == 3)
			{
				Console.WriteLine(values[nodeIndex] + " ");
				return values[nodeIndex];
			}

			if (maximizingPlayer)
			{
				int best = MIN;

				// Recur for left and 
				// right children 
				for (int i = 0; i < 2; i++)
				{
					int val = minimax(depth + 1, nodeIndex * 2 + i,
									false, values, alpha, beta);
					best = Math.Max(best, val);
					alpha = Math.Max(alpha, best);

					// Alpha Beta Pruning 
					//if (beta <= alpha) 
					//	break; 
				}

				x[poz] = (char)best;
				poz++;
				//Console.WriteLine("NIV 2-->" + best + "\n");
				return best;
			}
			else
			{
				int best = MAX;

				// Recur for left and 
				// right children 
				for (int i = 0; i < 2; i++)
				{

					int val = minimax(depth + 1, nodeIndex * 2 + i,
									true, values, alpha, beta);
					best = Math.Min(best, val);
					beta = Math.Min(beta, best);

					// Alpha Beta Pruning 
					//if (beta <= alpha)
					//	break;
				}
				x[poz] = best;
				poz++;
				//Console.WriteLine("NIV 1-->" + best + "\n");
				return best;
			}
		}
		private void button1_Click(object sender, EventArgs e)
        {

			int[] values = { 3, 5, 6, 9, 1, 2, 0, -1 };
			int z;
			z=minimax(0, 0, true, values, MIN, MAX);
			x[poz] = z;
			l1.Text = x[poz].ToString();
			poz = 1;
			arr1.Visible = true;
			button1.Visible = false;
			button3.Visible = true;
		}

        private void button3_Click(object sender, EventArgs e)
        {
			PictureBox[] pictures = new PictureBox[] { arr1, arr2, arr3, arr4, arr5, arr6, arr7 };
			Label[] labels = new Label[] { l1, l2, l3, l4, l5, l6, l7 };
			if (poz < 7)
            {
				pictures[poz - 1].Visible = false;
				pictures[poz].Visible = true;
				labels[poz].Text = x[poz].ToString();
				poz++;
			}
            if (poz == 7)
            {
				button1.Visible = false;
				button3.Visible = false;
			}
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
