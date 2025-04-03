// Copyright 2025 (c) Tangha Technologies, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class MongoDBDriverDemoEditorTarget : TargetRules
{
	public MongoDBDriverDemoEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "MongoDBDriverDemo" } );
	}
}
