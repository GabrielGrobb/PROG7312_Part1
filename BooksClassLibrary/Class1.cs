using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksClassLibrary
{
    public class Class1
    {
        /// <summary>
        /// Used ChatGPT here.
        /// A method to calculate the center point of the top and bottom shelf panel.
        /// The center point of a panel is derived from the x and y axis.
        /// </summary>
        /// <param name="panel">The top and bottom shelf panel</param>
        /// <returns></returns>
        public static Point CalculateCenter(Panel panel)
        {
            int centerX = panel.Left + panel.Width / 2;
            int centerY = panel.Top + panel.Height / 2;
            return new Point(centerX, centerY);
        }

        //------------------------------------------------------------------------------------------//

        /// <summary>
        /// Used ChatGPT here.
        /// A method to calculate the distance of between the top and bottom shelf panel.
        /// </summary>
        /// <param name="point1">The center point of the bottom shelf panel</param>
        /// <param name="point2">The center point of the top shelf panel</param>
        /// <returns></returns>
        public static double CalculateDistance(Point point1, Point point2)
        {
            double dx = point1.X - point2.X;
            double dy = point1.Y - point2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        //------------------------------------------------------------------------------------------//
    }
}
//------------------------------------------EndOfFile-----------------------------------------------//
