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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public struct Vertex
        {
            public char Label;
            public bool Visited;
        }

        private static int _rear = -1;
        private static int _front = 0;
        private static int _queueItemCount = 0;
        private static int _vertexCount = 0;

        private static void Insert(int[] queue, int data)
        {
            queue[++_rear] = data;
            _queueItemCount++;
        }

        private static int RemoveData(int[] queue)
        {
            _queueItemCount--;
            return queue[_front++];
        }

        private static bool IsQueueEmpty()
        {
            return _queueItemCount == 0;
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
        public static void DisplayVertex(Vertex[] arrVertices, int vertexIndex)
        {
            x[poz] = arrVertices[vertexIndex].Label;
            poz++;
            Console.Write(arrVertices[vertexIndex].Label + " ");
        }

        private static int GetAdjacentUnvisitedVertex(Vertex[] arrVertices, int[,] adjacencyMatrix, int vertexIndex)
        {
            int i;

            for (i = 0; i < _vertexCount; i++)
            {
                if (adjacencyMatrix[vertexIndex, i] == 1 && arrVertices[i].Visited == false)
                    return i;
            }

            return -1;
        }

        public static void BreadthFirstSearch(Vertex[] arrVertices, int[,] adjacencyMatrix, int[] queue)
        {
            int i;
            arrVertices[0].Visited = true;
            DisplayVertex(arrVertices, 0);
            Insert(queue, 0);
            int unvisitedVertex;

            while (!IsQueueEmpty())
            {
                int tempVertex = RemoveData(queue);

                while ((unvisitedVertex = GetAdjacentUnvisitedVertex(arrVertices, adjacencyMatrix, tempVertex)) != -1)
                {
                    arrVertices[unvisitedVertex].Visited = true;
                    DisplayVertex(arrVertices, unvisitedVertex);
                    Insert(queue, unvisitedVertex);
                }
            }

            for (i = 0; i < _vertexCount; i++)
            {
                arrVertices[i].Visited = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _rear = -1;
            _front = 0;
            _queueItemCount = 0;
            _vertexCount = 0;
            x = new char[10];
            poz = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int max = 7;
            int[] queue = new int[max];
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

            Console.Write("Breadth First Search: ");
            BreadthFirstSearch(arrVertices, adjacencyMatrix, queue);
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
                pictures[poz - 1].Visible = false;
                pictures[poz].Visible = true;
                label1.Text = label1.Text + " " + x[poz];
                poz++;
            }
            if (poz == 7)
            {
                button1.Visible = false;
                button3.Visible = false;
            }

        }
    }
}
