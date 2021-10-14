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
    public partial class Form6 : Form
    {
        public Form6()
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
        static char[] x = new char[101];
        static int poz = 0;
        private static void DisplayVertex(Vertex[] arrVertices, int vertexIndex)
        {
            x[poz] = arrVertices[vertexIndex].Label;
            poz++;
            Console.Write(arrVertices[vertexIndex].Label + " ");
        }

        private static int GetAdjacentUnvisitedVertex(Vertex[] arrVertices, int[,] adjacencyMatrix, int vertexIndex, int niv)
        {
            for (int i = 0; i < _vertexCount; ++i)
            {
                if (adjacencyMatrix[vertexIndex, i] == 1 && arrVertices[i].Visited == false && arrVertices[i].Nivel <= niv)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void DepthLimitedSearch(Vertex[] arrVertices, int[,] adjacencyMatrix, int[] stack, int niv)
        {
            arrVertices[0].Visited = true;
            DisplayVertex(arrVertices, 0);
            Push(stack, 0);

            while (!IsStackEmpty())
            {
                int unvisitedVertex = GetAdjacentUnvisitedVertex(arrVertices, adjacencyMatrix, Peek(stack), niv);

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
        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Text = "F";
            _top = -1;
            _vertexCount = 0;
            x = new char[101];
            poz = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            N = textBox1.Text[0];
            int max = 11;
            int[] stack = new int[101];
            Vertex[] arrVertices = new Vertex[101];
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

            for (int i = 0; i <= 3; i++)
            {
                DepthLimitedSearch(arrVertices, adjacencyMatrix, stack, i);
            }
            label1.Text = x[0] + "";
            nrNoduri = poz;
            poz = 1;
            arrA.Visible = true;
            button1.Visible = false;
            button3.Visible = true;
            textBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PictureBox[] pictures = new PictureBox[] { arrA, arrB, arrC, arrD, arrE, arrF, arrG, arrH, arrI, arrJ, arrK };
            if (x[poz] == 'A') label1.Text = "";
            if (x[poz] != N)
            {
                pictures[(int)x[poz - 1] - 65].Visible = false;
                pictures[(int)x[poz] - 65].Visible = true;
                label1.Text = label1.Text + " " + x[poz];
                poz++;
            }
            else
            {
                pictures[(int)x[poz - 1] - 65].Visible = false;
                pictures[(int)x[poz] - 65].Visible = true;
                label1.Text = label1.Text + " " + x[poz];
                poz++;
                button1.Visible = false;
                button3.Visible = false;
            }
        }
    }
}
