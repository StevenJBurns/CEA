using System;
using System.Activities;
using System.Workflow.Activities;

namespace CEA.Library.Workflow
{
    public sealed partial class MinimumDropzoneSizeWorkflow // ://SequentialWorkflowActivity
		{		
		AircraftType	aircrafttype;
		Int32			aircraftcount;
		Int32			dropaltitude;
		DayNight		tod;
		DropMethod		dropmethod;
		DropType		equipmenttype;
		Int32			equipmentcount;
				
		Size dz_size;
		
		
		public MinimumDropzoneSizeWorkflow()
			{
			InitializeComponent();
			}
		
		private Int32 AdditionalLengthCDS(Int32 containercount)
			{
			return 0;
			}
		
		private Int32 AdditionalLengthHE(Int32 platformcount)
			{
			return 0;
			}

		private Int32 AdditionalLengthPersonnel(Int32 jumpercount)
			{
			return jumpercount * 75;
			}
		}
	}