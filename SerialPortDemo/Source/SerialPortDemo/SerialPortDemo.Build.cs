// Copyright 2025 (c) Tangha Technology (suzhou) Co., Ltd. All Rights Reserved.

using UnrealBuildTool;

public class SerialPortDemo : ModuleRules
{
	public SerialPortDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "SerialPort" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
