using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace AirForce
	{
	public interface IEnlisted
		{
		
		}

	public abstract class Crewmember
		{
		private string ssn;
		private string firstname;
		private string lastname;
		private string mi;
		private string unit;
		private bool current;
		private bool qualified;
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


		#region IEnumerable Members

		public IEnumerator GetEnumerator()
			{
		throw new Exception("The method or operation is not implemented.");
			}

		#endregion
		}


	public class Navigator : Crewmember
		{
		public const CrewPosition crewposition = CrewPosition.Navigator;
		private OfficerGrades grade;

		public OfficerGrades Grade
			{
			get { return grade; }
			set { grade = value; }
			}

		}

	public class Pilot : Crewmember
		{
		public const CrewPosition crewposition = CrewPosition.Pilot;
		private OfficerGrades grade;

		public OfficerGrades Grade
			{
			get { return grade; }
			set { grade = value; }
			}
		}


	public class MissionCommanders : List<Crewmember>
		{

		}

	public class DeputyMissionCommanders : List<Crewmember>
		{

		}
}