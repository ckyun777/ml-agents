ECHO ML Agent Batch!!
@ECHO OFF

IF "%1"=="" (
	ECHO Run ID is missing.
) ELSE ( 	
	mlagents-learn config/trainer_config.yaml --run-id=%1 --train
)

