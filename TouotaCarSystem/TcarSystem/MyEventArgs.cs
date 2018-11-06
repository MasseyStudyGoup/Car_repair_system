using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcarSystem
{
    public class MyEventArgs : EventArgs
    {
        /// <summary>
        /// The identity of the transport event
        /// </summary>
        public int Temp { get; set; }

        /// <summary>
        /// Object to transfer events
        /// </summary>
        public object obj {get; set;}
    }
}
