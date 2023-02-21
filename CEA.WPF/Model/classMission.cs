using System;
using System.Collections.Generic;
using System.Text;

namespace CEA.Model
    {

    public enum DayNight
        {
        Day=1,
        Night,
        NightNVGs
        }
    public enum FormationPosition
        {
        FlightLead,
        ElementLead,
        Wingman
        }
    public enum MissionType
        {
        Unilateral,
        JAATT,
        Contingency
        }
    public enum DropMethod
        {
        Visual,
        SKE,
        SCNS,
        AWADS
        }

    }

namespace CEA.Model
    {
    public class Mission
        {
        private int missionID;
        private string missioncallsign;
        private DateTime missiondate;
        private Crewmember mc;
        private Crewmember dmc;
        private bool isformation;
        private List<MissionLine> sorties;

        public int MissionID
            {
            get {return missionID;}
            set {missionID = value;}
            }

        public DateTime MissionDate
            {
            get {return missiondate;}
            set {missiondate = value;}
            }

        public string Callsign
            {
            get {return missioncallsign;}
            set {missioncallsign = value;}
            }
        
        public Crewmember MC
            {
            get {return mc;}
            set {mc = value;}
            }

        public Crewmember DMC
            {
            get {return dmc;}
            set {dmc = value;}
            }

        public bool IsFormation
            {
            get {return isformation;}
            set {isformation = value;}
            }

        public List<MissionLine> Sorties
            {
            get { return sorties; }
            set { sorties = value; }
            }


        public Mission()
            {
            }
        
        public Mission (int missionID, DateTime dt, string missioncallsign, Crewmember mc, Crewmember dmc)
            {
            this.MissionID = missionID;
            this.MissionDate = dt;
            this.Callsign = missioncallsign;
            this.MC = mc;
            this.DMC = dmc;
            }
        
        }

    public class MissionLine
        {
        private int lineID;
        private int relatedmissionID;
        private string sortiecallsign;
        private Crewmember aircraftcommander;

        public MissionLine()
            {

            }

        public MissionLine(int sortieID, int relatedmissionID, string sortiecallsign, Crewmember aircraftcommander)
            {

            }

        public int LineID
            {
            get { return lineID; }
            set { lineID = value; }
            }

        public int RelatedMissionID
            {
            get { return relatedmissionID; }
            set { relatedmissionID = value; }
            }

        public string SortieCallsign
            {
            get { return sortiecallsign; }
            set { sortiecallsign = value; }
            }

        public Crewmember AircraftCommander
            {
            get { return aircraftcommander; }
            set { aircraftcommander = value; }
            }
        
        }

    public class MissionRunIn
        {
        private int runinID;
        private DateTime runindate;
        private int relatedlineID;
        private Crewmember dropNav;
        private Crewmember dropPilot;

        private Dropzone dz;
        private DayNight dn;
        private FormationPosition pos;
        private DropType droptype;
        private MissionType missiontype;
        private DropMethod dropmethod;

        private DateTime plannedTOT;
        private DateTime actualTOT;
        private byte relayeddrift;
        private byte actualdrift;

        private ScoreResult dropresult;
        private DropScore score;

        private string dropremarks;
        }

    public class FormationLineUp
        {
        private List<MissionLine> lineup;
        private TOT tot;
        private Dropzone dz;
        private MissionLine mc;
        private MissionLine dmc;        
        private MissionLine lead;
        private MissionLine phantom;

        public FormationLineUp()
            {
            mc = new MissionLine();
            dmc = new MissionLine();
            lead = new MissionLine();
            }
        
        public List<MissionLine> Lineup
            {
            get { return lineup; }
            set { lineup = value; }
            }

        public MissionLine Lead
            {
            get { return lead; }
            set { lead = value; }
            }

        public MissionLine MC
            {
            get { return mc; }
            set { mc = value; }
            }

        public MissionLine DMC
            {
            get { return dmc; }
            set { dmc = value; }
            }

        private bool ValidWingPosition(int position)
            {
            if ((position % 2 == 0) && (lineup[position - 1] != null))
                return true;
            else
                return false;
            }

        private bool ValidElementLeadPosition(int position)
            {
            if ((position % 2 == 1) && (lineup[position - 2] != null))
                return true;
            else
                return false;
            }

        private bool ValidFlightLeadPosition(int position)
            {
            if ((position % 2 == 1) && (lineup[position - 4] != null) && (position - 4 != 1))
                return true;
            else
                return false;
            }
                
        }
    }
