using CEA.Domain.Dropscore;

namespace CEA.Domain.Airdrop;

public struct DropScore
  {
  private DropscoreResult result;
  private Int32 rawrange;
  private Int32 rawclock;
  private Boolean isPI;
  private Boolean cancorrect;
  private Boolean iscorrected;

  public DropscoreResult Result
    {
    get { return result; }
    set { result = value; }
    }

  public Int32 RawRange
    {
    get { return rawrange; }
    set { rawrange = value; }
    }

  public Int32 RawClock
    {
    get { return rawclock; }
    set { rawclock = value; }
    }

  public Boolean PI
    {
    get { return isPI; }
    }

  public Boolean CanCorrect
    {
    get { return cancorrect; }
    set { cancorrect = value; }
    }

  public Boolean IsCorrected
    {
    get { return iscorrected; }
    set { iscorrected = value; }
    }

  public DropScore(Int32 range, Int32 clock)
    {
    this.result = DropscoreResult.Scored;
    this.rawrange = range;
    this.rawclock = clock;
    this.isPI = false;
    this.cancorrect = false;
    this.iscorrected = false;
    }

  public DropScore(DropscoreResult r)
    {
    result = r;

	switch (r)
      {
      case DropscoreResult.NoDrop:
        this.rawrange = 0;
        this.rawclock = 0;
        break;
      case DropscoreResult.Scored:
        this.rawrange = 36;
        this.rawclock = 12;
        break;
      case DropscoreResult.ScoredPI:
        this.rawrange = 1;
        this.rawclock = 12;
        break;
      case DropscoreResult.ScoredSAT:
        this.rawrange = 0;
        this.rawclock = 0;
        break;
      case DropscoreResult.ScoredUNSAT:
        this.rawrange = 0;
        this.rawclock = 0;
        break;
      default:
        this.rawrange = 0;
        this.rawclock = 0;
        break;
      }

	this.isPI = false;
	this.cancorrect = false;
	this.iscorrected = false;
    }

  private Boolean DeterminePI()
    {
    if (rawrange < 36 && rawrange > 0)
      {
      isPI = true;
      return true;
      } else {
      isPI = false;
      return false;
      }
    }

  public DropScore CorrectDropscore(DropScore leaderscore)
    {
    DropScore correctedscore = new DropScore();
    return correctedscore;
    }

  public override String ToString()
    {
    switch (result)
      {
      case DropscoreResult.NoDrop:
        return "No-Drop";
      case DropscoreResult.Scored:
		return RawRange.ToString() + "@" + RawClock.ToString();
      case DropscoreResult.ScoredPI:
        return "PI";
      case DropscoreResult.ScoredSAT:
        return "SAT";
      case DropscoreResult.ScoredUNSAT:
        return "UNSAT";
      default:
        return "Score Not Available";
      }
    //return Range.ToString() + "@" + Clock.ToString();
    }
  }
  