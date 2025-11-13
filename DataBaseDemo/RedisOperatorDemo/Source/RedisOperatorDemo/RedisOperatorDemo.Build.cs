// Copyright 2025 (c) Tangha Technology (suzhou) Co., Ltd. All Rights Reserved.

using UnrealBuildTool;

public class RedisOperatorDemo : ModuleRules
{
	public RedisOperatorDemo(ReadOnlyTargetRules Target) : base(Target)
	{
        if (Target.Configuration != UnrealTargetConfiguration.Shipping)
        {
            OptimizeCode = CodeOptimization.Never;
        }

        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

	}
}
