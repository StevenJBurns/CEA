using System;
using System.Collections.Generic;
using System.Text;


namespace AirForce.Airdrop
	{

	public class FormationLineUp
		{
		private List<MissionLine> lineup;
		private TOT tot_planned;
		private TOT tot_actual;
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

		private Boolean ValidWingPosition(Int32 position)
			{
			if ((position % 2 == 0) && (lineup[position - 1] != null))
				return true;
			else
				return false;
			}

		private Boolean ValidElementLeadPosition(Int32 position)
			{
			if ((position % 2 == 1) && (lineup[position - 2] != null))
				return true;
			else
				return false;
			}

		private bool ValidFlightLeadPosition(Int32 position)
			{
			if ((position % 2 == 1) && (lineup[position - 4] != null) && (position - 4 != 1))
				return true;
			else
				return false;
			}

		}
		
	}
