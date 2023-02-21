namespace CEA.Domain
{
  public sealed class Pilot : Crewmember
  {
    private OfficerGrades grade;

    public Pilot() { }

    public const CrewPosition crewposition = CrewPosition.Pilot;

    public OfficerGrades Grade
    {
      get { return grade; }
      set { grade = value; }
    }
  }
}
