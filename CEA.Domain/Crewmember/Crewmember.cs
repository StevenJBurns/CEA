using System.Collections;

namespace CEA.Domain.Crewmember;
  
public abstract class Crewmember
  {
  private string ssn;
  private string firstname;
  private string lastname;
  private string mi;
  private string unit;
  private bool isCurrent;
  private bool isQualified;
  private bool instructor;
  private bool evaluator;

  public Crewmember()
    {
    }

  public string SSN
    {
    get { return ssn; }
    set { ssn = value; }
    }

  public string FirstName
    {
    get { return firstname; }
    set { firstname = value; }
    }

  public string LastName
	{
    get { return lastname; }
    set { lastname = value; }
    }

  public string MI
    {
    get { return mi; }
    set { mi = value; }
    }

  public string FullName
    {
    get { return $"{lastname}, {firstname} {mi}"; }
    }

  public string Unit
    {
    get { return unit; }
    set { unit = value; }
    }

  public bool Instructor
    {
    get { return instructor; }
    set { instructor = value; }
    }

  public bool Evaluator
    {
    get { return evaluator; }
    set { evaluator = value; }
    }

  public override string ToString()
    {
    return FullName;
    }

  public IEnumerator GetEnumerator()
    {
    throw new Exception("The method or operation is not implemented.");
    }
  }

public class MissionCommanders : List<Crewmember> {}

public class DeputyMissionCommanders : List<Crewmember> {}
