using System;
using System.Collections.Generic;
using System.Text;

namespace AirForce.Airdrop
	{
	public class MissionRunIn
		{
		private Int32 runinID;
		private DateTime runindate;
		private Int32 relatedlineID;
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
		private Byte relayeddrift;
		private Byte actualdrift;

		private ScoreType dropresult;
		private DropScore score;

		private String dropremarks;
		}
	}