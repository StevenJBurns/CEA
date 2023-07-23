using CEA.Domain.Mission;

namespace CEA.Domain.Airdrop;
	
public class Mission
	{
	private Int32 missionID;
	private String? missioncallsign;
	private DateTime missiondate;
	private Crewmember.Crewmember? mc;
	private Crewmember .Crewmember? dmc;
	private Boolean isformation;
	private List<MissionLine>? lines;

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
		get { return missioncallsign ?? String.Empty; }
		set { missioncallsign = value; }
		}

	public Crewmember.Crewmember MC
		{
		get { return mc; }
		set { mc = value; }
		}

	public Crewmember .Crewmember DMC
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

	public Mission(Int32 missionID, DateTime dt, String missioncallsign, Crewmember.Crewmember mc, Crewmember.Crewmember dmc)
		{
		this.MissionID = missionID;
		this.MissionDate = dt;
		this.Callsign = missioncallsign;
		this.MC = mc;
		this.DMC = dmc;
		}

	}
	

