using CEA.Domain.Crewmember;

namespace CEA.Domain.Mission;

public class MissionLine
  {
  private Int32 lineID;
  private Int32 parentmissionID;
  private String? sortiecallsign;
  private Crewmember.Crewmember? aircraftcommander;

  public MissionLine()
    {
    this.sortiecallsign = String.Empty;
    }

  public MissionLine(Int32 sortieID, Int32 relatedmissionID, String sortiecallsign, Crewmember.Crewmember aircraftcommander)
    {
        this.sortiecallsign = sortiecallsign;
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

  public Crewmember.Crewmember AircraftCommander
    {
    get { return aircraftcommander; }
    set { aircraftcommander = value; }
    }
  }