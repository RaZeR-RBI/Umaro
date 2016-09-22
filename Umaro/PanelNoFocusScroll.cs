using System.Windows.Forms;

namespace Umaro
{
    public class PanelNoFocusScroll : Panel
    {
        //This code prevents the autoscrolling feature on control focus
        protected override System.Drawing.Point ScrollToControl(Control activeControl)
        {
            return DisplayRectangle.Location;
        }
    }
}
