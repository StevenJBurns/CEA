using CEA.Domain;
using CEA.Domain.Dropzone;
using CEA.Domain.Mission;

namespace CEA.Domain.Airdrop;

public class FormationLineUp
  {
  private List<MissionLine> lineup;
  private TimeOverTarget tot_planned;
  private TimeOverTarget tot_actual;
  private Dropzone.Dropzone? dz;
  private MissionLine mc;
  private MissionLine dmc;
  private MissionLine lead;
  private MissionLine? phantom;

  public FormationLineUp()
    {
    mc = new MissionLine();
    dmc = new MissionLine();
    lead = new MissionLine();
    lineup = new List<MissionLine>();
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
    return ((position % 2 == 0) && (lineup[position - 1] != null));
    }

  private Boolean ValidElementLeadPosition(Int32 position)
    {
    return ((position % 2 == 1) && (lineup[position - 2] != null));
    }

  private bool ValidFlightLeadPosition(Int32 position)
    {
    return ((position % 2 == 1) && (lineup[position - 4] != null) && (position - 4 != 1));
    }
  }