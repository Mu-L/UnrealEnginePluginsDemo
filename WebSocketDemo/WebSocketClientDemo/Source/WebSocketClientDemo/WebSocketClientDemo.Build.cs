// Copyright 2025 (c) WanWanHa, LLC. All Rights Reserved.

using UnrealBuildTool;

public class WebSocketClientDemo : ModuleRules
{
	public WebSocketClientDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] { "WebSocketClient" });


	}
}
