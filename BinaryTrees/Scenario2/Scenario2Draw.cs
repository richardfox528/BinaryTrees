using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BinaryTrees.Scenario2
{
    public partial class Scenario2Draw : UserControl
    {
        private PictureBox pictureBox;

        Node root;

        public Scenario2Draw()
        {
            InitializeComponent();

            pictureBox = new PictureBox
            {
                Size = new Size(500, 10),
                Location = new Point(0, 0),
                Parent = this
            };

            ConstructTree();
            ShowTreeGraph();
        }

        private void ConstructTree()
        {
            int[] preOrden = { 50, 17, 12, 9, 14, 23, 19, 72, 54, 67, 76 };
            int[] inOrden = { 9, 12, 14, 17, 19, 23, 50, 54, 67, 72, 76 };

            root = BuildTree(preOrden, inOrden);
        }

        private Node BuildTree(int[] preOrden, int[] inOrden)
        {
            if (preOrden.Length == 0 || inOrden.Length == 0)
                return null;

            int rootValue = preOrden[0];
            Node rootNode = new Node(rootValue);

            int rootIndexInInOrden = Array.IndexOf(inOrden, rootValue);

            int[] leftInOrden = inOrden.Take(rootIndexInInOrden).ToArray();
            int[] rightInOrden = inOrden.Skip(rootIndexInInOrden + 1).ToArray();

            int[] leftPreOrden = preOrden.Skip(1).Take(leftInOrden.Length).ToArray();
            int[] rightPreOrden = preOrden.Skip(1 + leftInOrden.Length).ToArray();

            rootNode.Left = BuildTree(leftPreOrden, leftInOrden);
            rootNode.Right = BuildTree(rightPreOrden, rightInOrden);

            return rootNode;
        }

        public void ShowTreeGraph()
        {
            pictureBox.Paint += Scenario2Draw_Paint;
        }

        private void DrawTree(Node node, Graphics g, int x, int y, int offsetX, int offsetY)
        {
            if (node == null) return;

            // lines 
            int nextX = offsetX / 2;
            int nextY = offsetY + y;

            if (node.Left != null)
            {
                // LInes Left
                g.DrawLine(Pens.Black, x, y, x - nextX, nextY);
                DrawTree(node.Left, g, x - nextX, nextY, offsetX / 2, offsetY);
            }

            if (node.Right != null)
            {
                // Lines rigth
                g.DrawLine(Pens.Black, x, y, x + nextX, nextY);
                DrawTree(node.Right, g, x + nextX, nextY, offsetX / 2, offsetY);
            }

            g.FillEllipse(Brushes.LightBlue, x - 15, y - 15, 40, 40);
            g.DrawEllipse(Pens.Black, x - 15, y - 15, 40, 40);
            g.DrawString(node.Value.ToString(), this.Font, Brushes.Black, x - 4, y - 1);
        }

        private void Scenario2Draw_Paint(object sender, PaintEventArgs e)
        {
            DrawTree(root, e.Graphics, pictureBox.Width / 2, 30, 200, 100);
        }
    }
}
