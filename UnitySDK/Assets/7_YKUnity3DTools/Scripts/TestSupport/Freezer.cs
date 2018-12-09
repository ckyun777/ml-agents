using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freezer : MonoBehaviour {
	

	public int m_IterationCount = 1000000;  // 1 million iteration for default value

	private void Awake()
	{
		float startTime = Time.realtimeSinceStartup;

		// Do useless calculation and measure how long time takes to do it.
		float uselessNum = Time.time;
		for (int i = 0; i < m_IterationCount; i++)
		{
			uselessNum += i * 0.1f;
		}
		float timeInterval = Time.realtimeSinceStartup - startTime;

		// Adjust useless calculation iteration count so the whole loop will takes around 1s
		m_IterationCount = (int)(m_IterationCount * (1f / timeInterval));
	}

	void Start()
	{
		float uselessNum = Time.time;
		int delaySec = 10;	// about 10s delay

		for (int i = 0; i < m_IterationCount * delaySec ; i++)
		{
			uselessNum += i * 0.1f;
		}
	}

	// Update is called once per frame
	void Update()
	{
	
	}
}
