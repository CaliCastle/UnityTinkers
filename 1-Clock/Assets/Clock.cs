using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {

	[SerializeField] private Transform m_hoursTransform, m_minutesTransform, m_secondsTransform;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var time = System.DateTime.Now.TimeOfDay;
		m_hoursTransform.localRotation =
			Quaternion.Euler(0f, (float) time.TotalHours * 30f, 0f);
		m_minutesTransform.localRotation =
			Quaternion.Euler(0f, (float) time.TotalMinutes * 6f, 0f);
		m_secondsTransform.localRotation =
			Quaternion.Euler(0f, (float) time.TotalSeconds * 6f, 0f);
	}
}
