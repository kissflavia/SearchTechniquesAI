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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public struct Vertex
        {
            public char Label;
            public bool Visited;
        }

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

        public static void AddVertex(Vertex[] arrVertices, char label)
        {
            Vertex vertex = new Vertex();
            vertex.Label = label;
            vertex.Visited = false;
            arrVertices[_vertexCount++] = vertex;
        }

        public static void AddEdge(int[,] adjacencyMatrix, int start, int end)
        {
            adjacencyMatrix[start, end] = 1;
            adjacencyMatrix[end, start] = 1;
        }
        static char[] x = new char[10];
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
                if (adjacencyMatrix[vertexIndex, i] == 1 && arrVertices[i].Visited == false)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void DepthFirstSearch(Vertex[] arrVertices, int[,] adjacencyMatrix, int[] stack)
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
        private void button1_Click(object sender, EventArgs e)
        {
            int max = 7;
            int[] stack = new int[max];
            Vertex[] arrVertices = new Vertex[max];
            int[,] adjacencyMatrix = new int[max, max];

            for (int i = 0; i < max; i++)
                for (int j = 0; j < max; j++)
                    adjacencyMatrix[i, j] = 0;

            AddVertex(arrVertices, 'A');
            AddVertex(arrVertices, 'B');
            AddVertex(arrVertices, 'C');
            AddVertex(arrVertices, 'D');
            AddVertex(arrVertices, 'E');
            AddVertex(arrVertices, 'F');
            AddVertex(arrVertices, 'G');

            AddEdge(adjacencyMatrix, 0, 1);
            AddEdge(adjacencyMatrix, 0, 2);
            AddEdge(adjacencyMatrix, 1, 3);
            AddEdge(adjacencyMatrix, 1, 4);
            AddEdge(adjacencyMatrix, 2, 5);
            AddEdge(adjacencyMatrix, 2, 6);

            DepthFirstSearch(arrVertices, adjacencyMatrix, stack);
            label1.Text = x[0] + "";
            poz = 1;
            arrA.Visible = true;
            button1.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PictureBox[] pictures = new PictureBox[] { arrA, arrB, arrC, arrD, arrE, arrF, arrG };
            if (poz < 7)
            {
                pictures[(int)x[poz] - 65].Visible = true;
                pictures[(int)x[poz - 1] - 65].Visible = false;
                label1.Text = label1.Text + " " + x[poz];
                poz++;
            }
            if (poz == 7)
            {
                button1.Visible = false;
                button3.Visible = false;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            _top = -1;
            _vertexCount = 0;
            x = new char[10];
            poz = 0;
        }
    }
}
