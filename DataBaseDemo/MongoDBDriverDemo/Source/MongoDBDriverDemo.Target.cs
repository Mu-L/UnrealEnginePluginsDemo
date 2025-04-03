// Copyright 2025 (c) Tangha Technologies, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class MongoDBDriverDemoTarget : TargetRules
{
	public MongoDBDriverDemoTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "MongoDBDriverDemo" } );
	}
}
