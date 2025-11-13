// Copyright 2025 (c) Tangha Technology (suzhou) Co., Ltd. All Rights Reserved.

using UnrealBuildTool;

public class FileDownloaderDemo : ModuleRules
{
	public FileDownloaderDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

        if (Target.Configuration != UnrealTargetConfiguration.Shipping)
        {
            OptimizeCode = CodeOptimization.Never;
        }

        PrivateDependencyModuleNames.AddRange(new string[] {  });

	}
}
