using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipeGame
{
    class Pipe
    {
        int type;
        int[] access = new int[4];
        int rads;

        public int Rads
        {
            get { return rads; }
            set { rads = value; }
        } 
        public int[] Access
        {
            get { return access; }
            set { access = value; }
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

    }
}
