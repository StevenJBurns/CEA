using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace AirForce.Workflow
{
	partial class MinimumDropzoneSizeWorkflow
	{
		#region Designer generated code
		
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
		private void InitializeComponent()
		{
	//this.CanModifyActivities = true;
	System.Workflow.Activities.Rules.RuleSetReference rulesetreference1 = new System.Workflow.Activities.Rules.RuleSetReference();
	System.Workflow.Activities.Rules.RuleSetReference rulesetreference2 = new System.Workflow.Activities.Rules.RuleSetReference();
	System.Workflow.Activities.Rules.RuleSetReference rulesetreference3 = new System.Workflow.Activities.Rules.RuleSetReference();
	System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
	System.Workflow.Activities.Rules.RuleSetReference rulesetreference4 = new System.Workflow.Activities.Rules.RuleSetReference();
	System.Workflow.Activities.Rules.RuleSetReference rulesetreference5 = new System.Workflow.Activities.Rules.RuleSetReference();
	System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference2 = new System.Workflow.Activities.Rules.RuleConditionReference();
	System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference3 = new System.Workflow.Activities.Rules.RuleConditionReference();
	System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference4 = new System.Workflow.Activities.Rules.RuleConditionReference();
	System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference5 = new System.Workflow.Activities.Rules.RuleConditionReference();
	this.policyC130_HE = new System.Workflow.Activities.PolicyActivity();
	this.policyC130_Personnel = new System.Workflow.Activities.PolicyActivity();
	this.policyC130_HVCDS = new System.Workflow.Activities.PolicyActivity();
	this.policyC130_CDS = new System.Workflow.Activities.PolicyActivity();
	this.cagEquipmentTypesC141 = new System.Workflow.Activities.ConditionedActivityGroup();
	this.cagEquipmentTypesC5 = new System.Workflow.Activities.ConditionedActivityGroup();
	this.cagEquipmentTypesC17 = new System.Workflow.Activities.ConditionedActivityGroup();
	this.faultHandlersActivity1 = new System.Workflow.ComponentModel.FaultHandlersActivity();
	this.cancellationHandlerActivity1 = new System.Workflow.ComponentModel.CancellationHandlerActivity();
	this.policyNOTE1 = new System.Workflow.Activities.PolicyActivity();
	this.cagEquipmentTypesC130 = new System.Workflow.Activities.ConditionedActivityGroup();
	this.NoAircraftTypeSet = new System.Workflow.Activities.IfElseBranchActivity();
	this.IsC141 = new System.Workflow.Activities.IfElseBranchActivity();
	this.IsC5 = new System.Workflow.Activities.IfElseBranchActivity();
	this.IsC17 = new System.Workflow.Activities.IfElseBranchActivity();
	this.IsC130 = new System.Workflow.Activities.IfElseBranchActivity();
	this.faultHandlersActivity2 = new System.Workflow.ComponentModel.FaultHandlersActivity();
	this.cancellationHandlerActivity2 = new System.Workflow.ComponentModel.CancellationHandlerActivity();
	this.IfElseAircraftPath = new System.Workflow.Activities.IfElseActivity();
	// 
	// policyC130_HE
	// 
	this.policyC130_HE.Name = "policyC130_HE";
	rulesetreference1.RuleSetName = "C130_HE";
	this.policyC130_HE.RuleSetReference = rulesetreference1;
	// 
	// policyC130_Personnel
	// 
	this.policyC130_Personnel.Name = "policyC130_Personnel";
	rulesetreference2.RuleSetName = "C130_Personnel";
	this.policyC130_Personnel.RuleSetReference = rulesetreference2;
	// 
	// policyC130_HVCDS
	// 
	this.policyC130_HVCDS.Name = "policyC130_HVCDS";
	rulesetreference3.RuleSetName = "C130_HVCDS";
	this.policyC130_HVCDS.RuleSetReference = rulesetreference3;
	ruleconditionreference1.ConditionName = "EquipmentType_CDS";
	// 
	// policyC130_CDS
	// 
	this.policyC130_CDS.Name = "policyC130_CDS";
	rulesetreference4.RuleSetName = "C130_CDS";
	this.policyC130_CDS.RuleSetReference = rulesetreference4;
	this.policyC130_CDS.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference1);
	// 
	// cagEquipmentTypesC141
	// 
	this.cagEquipmentTypesC141.Name = "cagEquipmentTypesC141";
	// 
	// cagEquipmentTypesC5
	// 
	this.cagEquipmentTypesC5.Name = "cagEquipmentTypesC5";
	// 
	// cagEquipmentTypesC17
	// 
	this.cagEquipmentTypesC17.Name = "cagEquipmentTypesC17";
	// 
	// faultHandlersActivity1
	// 
	this.faultHandlersActivity1.Name = "faultHandlersActivity1";
	// 
	// cancellationHandlerActivity1
	// 
	this.cancellationHandlerActivity1.Name = "cancellationHandlerActivity1";
	// 
	// policyNOTE1
	// 
	this.policyNOTE1.Name = "policyNOTE1";
	rulesetreference5.RuleSetName = "NOTE1";
	this.policyNOTE1.RuleSetReference = rulesetreference5;
	// 
	// cagEquipmentTypesC130
	// 
	this.cagEquipmentTypesC130.Activities.Add(this.policyC130_CDS);
	this.cagEquipmentTypesC130.Activities.Add(this.policyC130_HVCDS);
	this.cagEquipmentTypesC130.Activities.Add(this.policyC130_Personnel);
	this.cagEquipmentTypesC130.Activities.Add(this.policyC130_HE);
	this.cagEquipmentTypesC130.Name = "cagEquipmentTypesC130";
	// 
	// NoAircraftTypeSet
	// 
	this.NoAircraftTypeSet.Name = "NoAircraftTypeSet";
	// 
	// IsC141
	// 
	this.IsC141.Activities.Add(this.cagEquipmentTypesC141);
	ruleconditionreference2.ConditionName = "IsAircraftC141";
	this.IsC141.Condition = ruleconditionreference2;
	this.IsC141.Name = "IsC141";
	// 
	// IsC5
	// 
	this.IsC5.Activities.Add(this.cagEquipmentTypesC5);
	ruleconditionreference3.ConditionName = "IsAircraftC5";
	this.IsC5.Condition = ruleconditionreference3;
	this.IsC5.Name = "IsC5";
	// 
	// IsC17
	// 
	this.IsC17.Activities.Add(this.cagEquipmentTypesC17);
	ruleconditionreference4.ConditionName = "IsAircraftC17";
	this.IsC17.Condition = ruleconditionreference4;
	this.IsC17.Name = "IsC17";
	// 
	// IsC130
	// 
	this.IsC130.Activities.Add(this.cagEquipmentTypesC130);
	this.IsC130.Activities.Add(this.policyNOTE1);
	this.IsC130.Activities.Add(this.cancellationHandlerActivity1);
	this.IsC130.Activities.Add(this.faultHandlersActivity1);
	ruleconditionreference5.ConditionName = "IsAircraftC130";
	this.IsC130.Condition = ruleconditionreference5;
	this.IsC130.Name = "IsC130";
	// 
	// faultHandlersActivity2
	// 
	this.faultHandlersActivity2.Name = "faultHandlersActivity2";
	// 
	// cancellationHandlerActivity2
	// 
	this.cancellationHandlerActivity2.Name = "cancellationHandlerActivity2";
	// 
	// IfElseAircraftPath
	// 
	this.IfElseAircraftPath.Activities.Add(this.IsC130);
	this.IfElseAircraftPath.Activities.Add(this.IsC17);
	this.IfElseAircraftPath.Activities.Add(this.IsC5);
	this.IfElseAircraftPath.Activities.Add(this.IsC141);
	this.IfElseAircraftPath.Activities.Add(this.NoAircraftTypeSet);
	this.IfElseAircraftPath.Name = "IfElseAircraftPath";
	// 
	// MinimumDropzoneSizeWorkflow
	// 
	//this.Activities.Add(this.IfElseAircraftPath);
	//this.Activities.Add(this.cancellationHandlerActivity2);
	//this.Activities.Add(this.faultHandlersActivity2);
	//this.Name = "MinimumDropzoneSizeWorkflow";
	//this.CanModifyActivities = false;

		}

		#endregion

		private PolicyActivity policyNOTE1;
		private PolicyActivity policyC130_HE;
		private PolicyActivity policyC130_Personnel;
		private PolicyActivity policyC130_HVCDS;
		private PolicyActivity policyC130_CDS;
		private ConditionedActivityGroup cagEquipmentTypesC141;
		private ConditionedActivityGroup cagEquipmentTypesC5;
		private ConditionedActivityGroup cagEquipmentTypesC17;
		private ConditionedActivityGroup cagEquipmentTypesC130;
		private FaultHandlersActivity faultHandlersActivity2;
		private CancellationHandlerActivity cancellationHandlerActivity2;
		private IfElseBranchActivity NoAircraftTypeSet;
		private IfElseBranchActivity IsC141;
		private IfElseBranchActivity IsC5;
		private IfElseBranchActivity IsC17;
		private IfElseBranchActivity IsC130;
		private FaultHandlersActivity faultHandlersActivity1;
		private CancellationHandlerActivity cancellationHandlerActivity1;
		private IfElseActivity IfElseAircraftPath;












































































	}
}
