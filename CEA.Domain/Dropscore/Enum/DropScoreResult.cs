namespace CEA.Domain.Dropscore;

[Flags]
public enum DropscoreResult
  {
  NoScore = 0,
  NoDrop = 1,
  ScoredSAT = 2,
  ScoredUNSAT = 4,
  Scored = 8,
  ScoredPI = 16,
  }
