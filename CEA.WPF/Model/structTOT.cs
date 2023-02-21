using System;
using System.Collections.Generic;
using System.Text;

namespace CEA.Model
    {

    public struct TOT
        {
        private int id;
        private DateTime plannedTOT;
        private DateTime actualTOT;
        private TimeSpan deviation;

        public int ID
            {
            get { return id; }
            set { id = value; }
            }

        public DateTime Planned
            {
            get { return plannedTOT; }
            set { plannedTOT = value; }
            }

        public DateTime Actual
            {
            get { return actualTOT; }
            set { actualTOT = value; }
            }

        public TimeSpan Deviation
            {
            get { return deviation; }
            set { deviation = this.plannedTOT - this.actualTOT; }
            }
        }
    }