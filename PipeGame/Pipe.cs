using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipeGame
{
    class Pipe
    {
        public int type;
        public int[] access = new int[4];
        public int rads;

        public Pipe(int type)
        {
            this.type = type;
            rads = 0;
            access = findAccess(type);
        }

        private int[] findAccess(int type)
        {
            if (type == 'x')
            {
                return new int[4] { 0, 0, 1, 1 };
            }
            else
            {
                return new int[4] { 0, 0, 0, 0 }; 
            }

        }




    }
}
