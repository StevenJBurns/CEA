namespace CEA.Domain.Crewmember
  {
  public sealed class Navigator : Crewmember
    {
    private OfficerGrades grade;
    
    public Navigator()
      {
      }

    public const CrewPosition crewposition = CrewPosition.Navigator;

    public OfficerGrades Grade
      {
      get { return grade; }
      set { grade = value; }
      }
    }
  }
