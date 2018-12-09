using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaleChanger : MonoBehaviour {
	public float m_TimeScale = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Plus))
		{
			Time.timeScale *= 2f;
		}

		if (Input.GetKeyUp(KeyCode.Minus))
		{
			Time.timeScale *= 0.5f;
		}

		if (Input.GetKeyUp(KeyCode.Alpha0))
		{
			Time.timeScale = 0f;
		}

		if (Input.GetKeyUp(KeyCode.Alpha1))
		{
			Time.timeScale = 1f;
		}

		m_TimeScale = Time.timeScale;
	}
}
