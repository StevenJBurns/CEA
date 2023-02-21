using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CEA.Model
  {

  public enum Commision
    {
    Officer = 1,
    Enlisted
    }
  public enum OfficerRanks
    {
    SecondLT=1,
    FirstLT,
    Capt,
    Maj,
    LtCol,
    Col
    }

  public class Crewmember
    {
    private string ssn;
    private string firstname;
    private string lastname;
    private string mi;
    private Commision comm;
    private OfficerRanks rank;
    private string unit;
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

        public OfficerRanks Rank
            {
            get { return rank; }
            set { rank = value; }
            }
        
        public string FullName
            {
            get { return lastname + ", " + firstname + " " + mi; }
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
        
    }
  }