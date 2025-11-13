// Copyright 2025 (c) Tangha Technology (suzhou) Co., Ltd. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameMode.h"
#include "EosSessionGameMode.generated.h"

/**
 * 
 */
UCLASS()
class EOSSESSIONDEMO_API AEosSessionGameMode : public AGameMode
{
	GENERATED_BODY()
	

public:

	virtual void PostLogin(APlayerController* NewPlayer) override;

};
