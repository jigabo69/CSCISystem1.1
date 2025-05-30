using System.Drawing;

namespace LiveCharts
{
    internal class WinForms
    {
        internal class CartesianChart
        {
            public CartesianChart()
            {
            }

            public Color BackColor { get; internal set; }
            public Point Location { get; internal set; }
            public string Name { get; internal set; }
            public Size Size { get; internal set; }
            public int TabIndex { get; internal set; }
            public string Text { get; internal set; }
        }
    }
}