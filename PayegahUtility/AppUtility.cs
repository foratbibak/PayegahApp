using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayegahUtility
{
    public class AppUtility
    {
        public static GraphicsPath SetFormRonded(Form form,int radius=30)
        {

            form.FormBorderStyle = FormBorderStyle.None; // remove default border
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(form.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(form.Width - radius, form.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, form.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            return path;
        }
    }
   

}
