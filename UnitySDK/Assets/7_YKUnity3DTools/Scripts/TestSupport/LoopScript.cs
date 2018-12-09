using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoopScript : MonoBehaviour
{
	public Text m_GUIText;
	float prevTime = 0f;

	void Awake()
	{
		// 시작 부터 흐른 진짜 시간을 저장 한다.
		// Save the real time since startup.
		prevTime = Time.realtimeSinceStartup;

		if (m_GUIText == null)
		{
			m_GUIText = FindObjectOfType<Text>() as Text;
		}
		
		print(" ==== Awake ==== " + gameObject.GetInstanceID() +
			"\t" + name + "\t" + Time.realtimeSinceStartup);
	}


	void Start()
	{
		print(" ==== Start ==== " + "\t" + gameObject.GetInstanceID() + 
			"\t" + name + "\t" + Time.realtimeSinceStartup);
	}


	void Update()
	{
		// 이전 호출과 이번 호출 사이에 흐른 시간을 계산한다.
		// Calculate the delta time between frames.
		float time = Time.realtimeSinceStartup;
		float dT = time - prevTime;

		print(" ==== Update ==== " + gameObject.GetInstanceID() +
			"\t" + name + "\t" + Time.realtimeSinceStartup);

		print(" == Real time : " + time + "\t" + " == Unity time : " + Time.time);
		print(" == Real delta time : " + dT + "\t" + " == Unity delta time : " + Time.deltaTime);		// This value is always less then 0.333...s

		// Move randomly to check system is not freezed or not.
		transform.Translate(Random.onUnitSphere * Time.deltaTime * 30f);

		// Show delta time to GUI Text
		if (m_GUIText != null)
		{
			m_GUIText.text = " Delta time : " + dT;
		}

		// 다음 Update 함수 호출과의 시간 간격을 구하기 위하여 현재시간을 저장해 놓는다.
		// Save current time as previous time
		prevTime = time;
	}
}

