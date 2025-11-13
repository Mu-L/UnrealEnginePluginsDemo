// Copyright 2025 (c) Tangha Technology (suzhou) Co., Ltd. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class WebSocketClientDemoTarget : TargetRules
{
	public WebSocketClientDemoTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.Add("WebSocketClientDemo");
	}
}
