namespace CEA.Model;

public struct Drift
  {
  private sbyte val;
  private char lr;

  public sbyte Val
  {
    get { return val; }
    set { val = value; }
  }

  public char LR
  {
    get
    {
      return (val < 0) ? 'L' : 'R';
    }
    set
    {
      lr = value;
    }
  }

  public override string ToString()
  {
    return $"{val.ToString()}{lr}";
  }
}
