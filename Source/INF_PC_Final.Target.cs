// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class INF_PC_FinalTarget : TargetRules
{
	public INF_PC_FinalTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "INF_PC_Final" } );
	}
}
