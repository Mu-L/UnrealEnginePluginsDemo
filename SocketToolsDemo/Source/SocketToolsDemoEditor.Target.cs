// Copyright 2025 (c) Tangha Technologies, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class SocketToolsDemoEditorTarget : TargetRules
{
	public SocketToolsDemoEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange( new string[] { "SocketToolsDemo" } );
	}
}
