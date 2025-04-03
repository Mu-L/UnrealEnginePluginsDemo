// Copyright 2025 (c) Tangha Technologies, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BiLiBiLiBarrageDemoTarget : TargetRules
{
	public BiLiBiLiBarrageDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.Add("BiLiBiLiBarrageDemo");
	}
}
