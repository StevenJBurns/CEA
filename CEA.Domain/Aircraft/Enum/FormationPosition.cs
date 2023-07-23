namespace CEA.Domain.Aircraft;

[Flags]
public enum FormationPosition
  {
  Unknown = 0,
  FormationLead = 1,
  SerialLead = 2,
  FlightLead = 4,
  ElementLead = 8,
  Wingman = 16
 }
