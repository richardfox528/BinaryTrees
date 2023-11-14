using System.Drawing;
using System.Windows.Forms;

namespace BinaryTrees.Scenario1
{
    public partial class Scenario1Draw : UserControl
    {
        public Node draw;

        public Scenario1Draw()
        {
            InitializeComponent();
            BuildTree();
        }

        private void BuildTree()
        {
            draw = new Node(70);
            draw.Left = new Node(20);
            draw.Right = new Node(98);
            draw.Left.Left = new Node(15);
            draw.Left.Right = new Node(59);
            draw.Right.Left = new Node(77);
            draw.Left.Left.Left = new Node(10);
            draw.Left.Left.Left.Left = new Node(2);
            draw.Left.Right.Left = new Node(29);
            draw.Left.Right.Right = new Node(69);
            draw.Right.Left.Left = new Node(75);
            draw.Right.Left.Right = new Node(91);
            draw.Right.Left.Right.Left = new Node(78);
            draw.Right.Left.Right.Left.Right = new Node(86);
        }

        private void DrawTree(Node nodo, Graphics g, int x, int y, int espace)
        {
            if (nodo == null) return;

            // draw line
            if (nodo.Left != null)
                DibujarLinea(g, Pens.Black, x - espace, y + 40, x, y);
            if (nodo.Right != null)
                DibujarLinea(g, Pens.Black, x + espace, y + 40, x, y);

            // draw node
            g.FillEllipse(Brushes.LightBlue, x - 20, y - 20, 40, 40);
            g.DrawEllipse(Pens.Black, x - 20, y - 20, 40, 40);
            g.DrawString(nodo.Value.ToString(), Font, Brushes.Black, x - 10, y - 10);

            // draw tree
            DrawTree(nodo.Left, g, x - espace, y + 55, espace / 2);
            DrawTree(nodo.Right, g, x + espace, y + 55, espace / 2);
        }

        private void DibujarLinea(Graphics g, Pen pen, int x1, int y1, int x2, int y2)
        {
            g.DrawLine(pen, x1, y1, x2, y2);
        }

        private void Scenario1Draw_Paint(object sender, PaintEventArgs e)
        {
            DrawTree(draw, e.Graphics, this.Width / 2, 50, 150);
        }

        public string PreOrden(Node node)
        {
            if (node == null)
                return string.Empty;

            return $"{node.Value} {PreOrden(node.Left)} {PreOrden(node.Right)}";
        }

        public string InOrden(Node node)
        {
            if (node == null)
                return string.Empty;

            return $"{InOrden(node.Left)} {node.Value} {InOrden(node.Right)}";
        }

        public string PostOrden(Node node)
        {
            if (node == null)
                return string.Empty;

            return $"{PostOrden(node.Left)} {PostOrden(node.Right)} {node.Value}";
        }
    }
}
