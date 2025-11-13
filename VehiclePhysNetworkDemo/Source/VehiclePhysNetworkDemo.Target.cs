// Copyright 2025 (c) Tangha Technology (suzhou) Co., Ltd. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class VehiclePhysNetworkDemoTarget : TargetRules
{
	public VehiclePhysNetworkDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;

		ExtraModuleNames.AddRange( new string[] { "VehiclePhysNetworkDemo" } );
	}
}
