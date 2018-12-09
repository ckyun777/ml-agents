using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class SimpleAgent : Agent {

	public Bandit bandit;

	public override void AgentAction(float[] vectorAction, string textAction)
	{
		var action = (int)vectorAction[0];
		Debug.Log("Action : " + action);
		AddReward(bandit.PullArm(action));
		Done();
	}

	public override void AgentReset()
	{
		bandit.Reset();
	}

	public override void CollectObservations()
    {
		AddVectorObs(0);
    }
	
   
    public override void AgentOnDone()
    {

    }

	public Academy academy;
	public float timeBetweenDecisionsAtInference;
	private float timeSinceDecision;

	public void FixedUpdate()
	{
		WaitTimeInference();
	}

	private void WaitTimeInference()
	{
		if (!academy.GetIsInference())
		{
			RequestDecision();
		}
		else
		{
			if (timeSinceDecision >= timeBetweenDecisionsAtInference)
			{
				timeSinceDecision = 0f;
				RequestDecision();
			}
			else
			{
				timeSinceDecision += Time.fixedDeltaTime;
			}
		}
	}
}
