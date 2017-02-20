using System;
using System.Collections.Generic;
using System.Text;

namespace CEA.Model
    {
    public struct Drift
        {
        private byte val;
        private char lr;

        public byte Val
            {
            get { return val; }
            set { val = value; }
            }

        public char LR
            {
            get
                {
                if (val < 0)
                    return 'L';
                else
                    return 'R';
                }
            set { lr = value; }
            }

        public override string ToString()
            {
            return val.ToString() + lr;
            }
        }


    }