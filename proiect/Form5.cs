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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public struct Vertex
        {
            public char Label;
            public bool Visited;
            public int Nivel;
        }
        public static int N = 3;
        public static int nrNoduri = 0;
        private static int _top = -1;
        private static int _vertexCount = 0;

        private static void Push(int[] stack, int item)
        {
            stack[++_top] = item;
        }

        private static int Pop(int[] stack)
        {
            return stack[_top--];
        }

        private static int Peek(int[] stack)
        {
            return stack[_top];
        }

        private static bool IsStackEmpty()
        {
            return _top == -1;
        }

        public static void AddVertex(Vertex[] arrVertices, char label, int niv)
        {
            Vertex vertex = new Vertex();
            vertex.Label = label;
            vertex.Visited = false;
            vertex.Nivel = niv;
            arrVertices[_vertexCount++] = vertex;
        }

        public static void AddEdge(int[,] adjacencyMatrix, int start, int end)
        {
            adjacencyMatrix[start, end] = 1;
            adjacencyMatrix[end, start] = 1;
        }
        static char[] x = new char[12];
        static int poz = 0;
        private static void DisplayVertex(Vertex[] arrVertices, int vertexIndex)
        {
            x[poz] = arrVertices[vertexIndex].Label;
            poz++;
            Console.Write(arrVertices[vertexIndex].Label + " ");
        }

        private static int GetAdjacentUnvisitedVertex(Vertex[] arrVertices, int[,] adjacencyMatrix, int vertexIndex)
        {
            for (int i = 0; i < _vertexCount; ++i)
            {
                if (adjacencyMatrix[vertexIndex, i] == 1 && arrVertices[i].Visited == false && arrVertices[i].Nivel<=N)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void DepthLimitedSearch(Vertex[] arrVertices, int[,] adjacencyMatrix, int[] stack)
        {
            arrVertices[0].Visited = true;
            DisplayVertex(arrVertices, 0);
            Push(stack, 0);

            while (!IsStackEmpty())
            {
                int unvisitedVertex = GetAdjacentUnvisitedVertex(arrVertices, adjacencyMatrix, Peek(stack));

                if (unvisitedVertex == -1)
                {
                    Pop(stack);
                }
                else
                {
                    arrVertices[unvisitedVertex].Visited = true;
                    DisplayVertex(arrVertices, unvisitedVertex);
                    Push(stack, unvisitedVertex);

                }
            }

            for (int i = 0; i < _vertexCount; ++i)
            {
                arrVertices[i].Visited = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PictureBox[] pictures = new PictureBox[] { arrA, arrB, arrC, arrD, arrE, arrF, arrG, arrH, arrI, arrJ, arrK };
            if (poz < nrNoduri)
            {
                pictures[(int)x[poz] - 65].Visible = true;
                pictures[(int)x[poz - 1] - 65].Visible = false;
                label1.Text = label1.Text + " " + x[poz];
                poz++;
            }
            if (poz == nrNoduri)
            {
                button1.Visible = false;
                button3.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            N = int.Parse(textBox1.Text);
            int max = 11;
            int[] stack = new int[max];
            Vertex[] arrVertices = new Vertex[max];
            int[,] adjacencyMatrix = new int[max, max];

            for (int i = 0; i < max; i++)
                for (int j = 0; j < max; j++)
                    adjacencyMatrix[i, j] = 0;

            AddVertex(arrVertices, 'A', 0);
            AddVertex(arrVertices, 'B', 1);
            AddVertex(arrVertices, 'C', 1);
            AddVertex(arrVertices, 'D', 2);
            AddVertex(arrVertices, 'E', 2);
            AddVertex(arrVertices, 'F', 2);
            AddVertex(arrVertices, 'G', 2);
            AddVertex(arrVertices, 'H', 3);
            AddVertex(arrVertices, 'I', 3);
            AddVertex(arrVertices, 'J', 3);
            AddVertex(arrVertices, 'K', 3);

            AddEdge(adjacencyMatrix, 0, 1);
            AddEdge(adjacencyMatrix, 0, 2);
            AddEdge(adjacencyMatrix, 1, 3);
            AddEdge(adjacencyMatrix, 1, 4);
            AddEdge(adjacencyMatrix, 2, 5);
            AddEdge(adjacencyMatrix, 2, 6);
            AddEdge(adjacencyMatrix, 4, 7);
            AddEdge(adjacencyMatrix, 4, 8);
            AddEdge(adjacencyMatrix, 6, 9);
            AddEdge(adjacencyMatrix, 6, 10);

            DepthLimitedSearch(arrVertices, adjacencyMatrix, stack);
            label1.Text = x[0] + "";
            nrNoduri = poz;
            poz = 1;
            arrA.Visible = true;
            button1.Visible = false;
            button3.Visible = true;
            textBox1.Enabled = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            _top = -1;
            _vertexCount = 0;
            x = new char[12];
            poz = 0;
        }
    }
}
