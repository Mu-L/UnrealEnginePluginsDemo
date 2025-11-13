// Copyright 2025 (c) Tangha Technology (suzhou) Co., Ltd. All Rights Reserved.


using UnrealBuildTool;

public class SQLiteDriverDemo : ModuleRules
{
	public SQLiteDriverDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] { "SQLiteDriver" });

	}
}
