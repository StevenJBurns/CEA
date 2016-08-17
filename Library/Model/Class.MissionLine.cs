using System;
using System.Collections.Generic;
using System.Text;

namespace AirForce.Airdrop
	{

	public class MissionLine
		{
		private Int32 lineID;
		private Int32 parentmissionID;
		private String sortiecallsign;
		private Crewmember aircraftcommander;

		public MissionLine()
			{

			}

		public MissionLine(Int32 sortieID, Int32 relatedmissionID, String sortiecallsign, Crewmember aircraftcommander)
			{

			}

		public Int32 LineID
			{
			get { return lineID; }
			set { lineID = value; }
			}

		public Int32 RelatedMissionID
			{
			get { return parentmissionID; }
			set { parentmissionID = value; }
			}

		public String SortieCallsign
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
			
	}