using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace CEA.Library.Workflow
	{
	public sealed partial class MinimumDropzoneSizeWorkflow: SequentialWorkflowActivity
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