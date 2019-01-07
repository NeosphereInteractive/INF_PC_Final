// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class INF_PC_FinalEditorTarget : TargetRules
{
	public INF_PC_FinalEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "INF_PC_Final" } );
	}
}
