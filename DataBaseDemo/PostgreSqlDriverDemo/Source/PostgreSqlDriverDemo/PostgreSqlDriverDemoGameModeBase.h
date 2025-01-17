// Copyright 2025 (c) WanWanHa, LLC. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "PostgreSqlDriverDemoGameModeBase.generated.h"

/**
 * 
 */
UCLASS()
class POSTGRESQLDRIVERDEMO_API APostgreSqlDriverDemoGameModeBase : public AGameModeBase
{
	GENERATED_BODY()
	

public:
	virtual void BeginPlay() override;
};
