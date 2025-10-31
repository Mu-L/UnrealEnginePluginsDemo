// Copyright 2025 (c) Tangha Technologies, LLC. All Rights Reserved.

using UnrealBuildTool;

public class SocketToolsDemo : ModuleRules
{
	public SocketToolsDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "RHI", "RenderCore", "SocketTools" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

        if (Target.Configuration != UnrealTargetConfiguration.Shipping)
        {
            OptimizeCode = CodeOptimization.Never;
        }

    }
}
