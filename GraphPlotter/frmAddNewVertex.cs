namespace GraphPlotter
{
    public partial class frmAddNewVertex : Form
    {
        public frmAddNewVertex()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        public Vertex NewVertex = new Vertex(new Point(0, 0), new List<int> { 0 });
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Color[] colors = { Color.Black, Color.Red, Color.Blue, Color.Magenta,  Color.Yellow, Color.Green };

            //No validation for the Coordinate yet
            NewVertex.SetPosition(new Point(Convert.ToInt16(txtX.Text), Convert.ToInt16(txtY.Text)));
            NewVertex.SetNeighbours(new List<int> { 0 });
            if(cmbColour.SelectedIndex != -1)
            NewVertex.SetBrushColor(colors[cmbColour.SelectedIndex]);
            this.DialogResult = DialogResult.OK;
        }
    }
}
