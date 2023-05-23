using System.Drawing;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT.Game.View;

public class TransparentPanel : Panel
{
    public TransparentPanel()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        BackColor = Color.Transparent;
    }
}