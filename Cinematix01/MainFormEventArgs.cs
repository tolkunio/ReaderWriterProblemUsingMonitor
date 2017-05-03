using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinematix01
{
    public class MainFormEventArgs : MouseEventArgs
    {
        public MainForm MainForm { get; set; }
        public MainFormEventArgs(MouseButtons button, int clicks, int x, int y, int delta) : base(button, clicks, x, y, delta)
        {

        }

    }
}
