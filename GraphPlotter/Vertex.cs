
namespace GraphPlotter
{
    public class Vertex
    {
        //Prefix "V" added to each property name to distinguish between the object and parameter
        private List<int> VNeighbours;
        private Point VPosition;
        private Brush VBrush;

        #region Constructors
        public Vertex(Point PositionPoint, List<int> Neighbours) 
        { 
            VPosition = PositionPoint;
            Neighbours = Neighbours;
            VBrush = new SolidBrush(Color.Red);
        }

        public Vertex(Point SetPos, List<int> SetNeighbours, Color BrushColor )
        {
            VPosition = SetPos;
            VNeighbours = SetNeighbours;
            VBrush = new SolidBrush(BrushColor);
        }
        #endregion

        #region Getter & setters
        public void SetBrushColor(Color NewColor)
        { 
            VBrush = new SolidBrush(NewColor);
        }
        public void SetPosition(Point NewPos)
        {
            VPosition = NewPos;
        }
        public void SetNeighbours(List<int> NewNeighbours)
        { 
            VNeighbours = NewNeighbours;
        }

        public Point GetPosition()
        {
            return VPosition;
        }

        public List<int> GetNeighbours()
        { 
            return VNeighbours;
        }

        public Brush GetBrush()
        {
            return VBrush;
        }
        #endregion
    }
}
