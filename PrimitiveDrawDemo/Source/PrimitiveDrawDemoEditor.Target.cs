// Copyright 2025 (c) Tangha Technology (suzhou) Co., Ltd. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class PrimitiveDrawDemoEditorTarget : TargetRules
{
	public PrimitiveDrawDemoEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange( new string[] { "PrimitiveDrawDemo" } );
	}
}
