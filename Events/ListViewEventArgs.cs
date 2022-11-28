using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Forms.Events
{
    public class ListViewEventArgs : EventArgs
    {
        public ListViewItem? Item { get; set; }
    }
}
