using System;
using System.Collections.Generic;
using System.Text;


namespace AirForce.Airdrop
	{	
	public class Mission
		{
		private Int32 missionID;
		private String missioncallsign;
		private DateTime missiondate;
		private Crewmember mc;
		private Crewmember dmc;
		private Boolean isformation;
		private List<MissionLine> lines;

		public Int32 MissionID
			{
			get { return missionID; }
			set { missionID = value; }
			}

		public DateTime MissionDate
			{
			get { return missiondate; }
			set { missiondate = value; }
			}

		public String Callsign
			{
			get { return missioncallsign; }
			set { missioncallsign = value; }
			}

		public Crewmember MC
			{
			get { return mc; }
			set { mc = value; }
			}

		public Crewmember DMC
			{
			get { return dmc; }
			set { dmc = value; }
			}

		public Boolean IsFormation
			{
			get { return isformation; }
			set { isformation = value; }
			}

		public List<MissionLine> Lines
			{
			get { return lines; }
			set { lines = value; }
			}


		public Mission()
			{
			}

		public Mission(Int32 missionID, DateTime dt, String missioncallsign, Crewmember mc, Crewmember dmc)
			{
			this.MissionID = missionID;
			this.MissionDate = dt;
			this.Callsign = missioncallsign;
			this.MC = mc;
			this.DMC = dmc;
			}

		}
		
	}
