using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Square
    {
        private int mSide;

        public int Side
        {
            get
            {
                return mSide;
            }
            set
            {
                if (mSide < 0) return;
                mSide = value;
            }
        }
    }
}
