using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiController
{
    public static class INVOKER
    {
        public static void InvokeControl(Control control, Action action)
        {
            if (control.InvokeRequired)
                control.BeginInvoke(new Action(() => InvokeControl(control, action)));
            else
                action();
        }
    }
}
