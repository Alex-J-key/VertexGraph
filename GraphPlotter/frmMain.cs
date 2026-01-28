namespace GraphPlotter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Shown(object sender, EventArgs e)
        {

            //Instantiate each Vertex which stores a Point (the position) and an Adjacency list of neighbouring vertices
            //The list of neighbours will contain 0 if there are no neighbours
            graph[1] = new Vertex(new Point(100, 510), new List<int> { 2, 3, 4 });
            graph[2] = new Vertex(new Point(150, 190), new List<int> { 1, 3, 4 });
            graph[3] = new Vertex(new Point(160, 250), new List<int> { 1, 2, 4 });
            graph[4] = new Vertex(new Point(110, 230), new List<int> { 1, 2, 3 });
            graph[5] = new Vertex(new Point(250, 120), new List<int> { 4, 6 }, Color.Magenta);
            graph[6] = new Vertex(new Point(420, 240), new List<int> { 5, 6 });
            graph[7] = new Vertex(new Point(380, 480), new List<int> { 0 }, Color.Blue);
            Draw();
        }

        //Instantiate the Dictionary graph which stores a value of Vertex Objects
        static public Dictionary<int, Vertex> graph = new Dictionary<int, Vertex>();
        public void Draw()
        {
            

            //Creating graphics
            Graphics g = this.CreateGraphics();

            Brush Black = new SolidBrush(Color.Black);

            //Determines the size (diameter of each vertex)
            Size VertexSize = new Size(10, 10);

            //Loops through the graph Dictionary to display each Vertex Object
            foreach (var v in graph)
            {
                //Assigning the Vertex from the graph to a temp Vertex Object
                Vertex vertex = graph[v.Key];

                Font normal = new Font(FontFamily.GenericSansSerif, 15.0f);

                //Fills the Ellipse (vertex circle) with the defined properties
                g.FillEllipse(vertex.GetBrush(), new RectangleF(vertex.GetPosition(), VertexSize));
                g.DrawString(Convert.ToString(v.Key), normal, Black, vertex.GetPosition().X + 5, vertex.GetPosition().Y);
            }



            /* TODO:
             * Draw the graph lines / edges by using the Vertex.GetNeighbour() method from each Vertex Object
             * Add a weighted property to the Vertex Class
             * Add a direction property to the Vertex Class
             */

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rerenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewVertex frmInsertVertex = new frmAddNewVertex();
            var result = new DialogResult();
            result = frmInsertVertex.ShowDialog();
            if (result == DialogResult.OK)
            {
                Vertex NewVertex1 = frmInsertVertex.NewVertex;
                graph.Add(graph.Count+1, NewVertex1);
                Draw();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Brush White = new SolidBrush(BackColor);
            g.FillRectangle(White, new RectangleF(0,0, this.Width, this.Height));
        }
    }
}

