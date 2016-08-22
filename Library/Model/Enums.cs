using System;

namespace AirForce
	{
	public enum CrewPosition
		{
		Unknown			= 0,
		Pilot			= 1,
		Navigator		= 2,
		FlightEngineer	= 3,
		Loadmaster		= 4
		}
	
	public enum OfficerGrades
		{
		Unknown = 0,
		O1,
		O2,
		O3,
		O4,
		O5,
		O6
		}
	
	public enum EnlistedGrades
		{
		Unknown = 0,
		E1,
		E2,
		E3,
		E4,
		E5,
		E6,
		E7,
		E8,
		E9
		}
	
	public enum DayNight
		{
		Unknown		= 0,
		Day			= 1,
		Night		= 2,
		NightNVG	= 3
		}
	}

namespace AirForce.Airdrop
	{
	
	public enum MissionType
		{
		Unknown		= 0,
		Unilateral	= 1,
		JAATT		= 2,
		Contingency	= 3
		}

	public enum MissionSize
		{
		Unknown				= 0,
		SingleShip			= 1,
		Formation			= 2,
		FormationDissimilar = 3
		}

	[Flags]
	public enum FormationPosition
		{
		Unknown			= 0,
		FormationLead	= 1,
		SerialLead		= 2,
		FlightLead		= 4,
		ElementLead		= 8,
		Wingman			= 16
		}		

	[Flags]
	public enum DropzoneType
		{
		Unknown			= 0,
		Rectangular		= 1,
		Circular		= 2,
		Area			= 4,
		RandomApproach	= 8
		}

	public enum DropMethod
		{
		Unknown	= 0,
		Visual	= 1,
		SKE		= 2,
		SCNS	= 3,
		AWADS	= 4
		}

	public enum DropType
		{
		Unknown = 0,
		HE = 1,
		CDS = 2,
		HVCDS = 3,
		Personnel = 4,
		MFF = 5,
		SATBH = 6,
		SATBC = 7,
		SATBP = 8,
		CRRC = 9,
		HSLADDS = 10
		}
	
	public enum CDS
		{
		Unknown = 0,
		Single	= 1,
		Double	= 2
		}
	
	[Flags]
	public enum ScoreType
		{
		NoScore		= 0,
		NoDrop		= 1,
		ScoredSAT	= 2,
		ScoredUNSAT	= 3,
		Scored		= 4,
		ScoredPI	= 5,
		}

	public enum NoDropCode
		{

		}
	
	}