using System;
using System.Collections.Generic;
using System.Text;


namespace AirForce.Airdrop
	{

	public struct DropScore
		{
		private ScoreType res;
		private Int32 rawrange;
		private Int32 rawclock;
		private Boolean isPI;
		private Boolean cancorrect;
		private Boolean iscorrected;

		public ScoreType Result
			{
			get { return res; }
			set { res = value; }
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
		this.res = ScoreType.Scored;
		this.rawrange = range;
		this.rawclock = clock;
		this.isPI = false;
		this.cancorrect = false;
		this.iscorrected = false;
			}

		public DropScore(ScoreType r)
			{
		res = r;

		switch (r)
			{
			case ScoreType.NoDrop:
				this.rawrange = 0;
				this.rawclock = 0;
				break;
			case ScoreType.Scored:
				this.rawrange = 36;
				this.rawclock = 12;
				break;
			case ScoreType.ScoredPI:
				this.rawrange = 1;
				this.rawclock = 12;
				break;
			case ScoreType.ScoredSAT:
				this.rawrange = 0;
				this.rawclock = 0;
				break;
			case ScoreType.ScoredUNSAT:
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
			}
		else
			{
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
		switch (res)
			{
			case ScoreType.NoDrop:
				return "No-Drop";
				break;
			case ScoreType.Scored:
				return RawRange.ToString() + "@" + RawClock.ToString();
				break;
			case ScoreType.ScoredPI:
				return "PI";
				break;
			case ScoreType.ScoredSAT:
				return "SAT";
				break;
			case ScoreType.ScoredUNSAT:
				return "UNSAT";
				break;
			default:
				return "Score Not Available";
				break;
			}

		//return Range.ToString() + "@" + Clock.ToString();
			}

		}

	}