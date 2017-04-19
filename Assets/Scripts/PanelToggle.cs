using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelToggle : MonoBehaviour
{
	[Tooltip("The object (container) to toggle.")]
	public GameObject Target;

	[Tooltip("Toggle key")]
	public string ToggleKey = "b";

	[Tooltip("Display on startup?")]
	public bool Visible = false;


	void Start()
	{
		// Set panel's default visibility.
		Target.SetActive(Visible);
	}

	void Update()
	{
		// Check key
		if (Input.GetKeyDown(ToggleKey))
		{
			// Toggle
			if (Visible == true)
			{
				Visible = false;
				Target.SetActive(Visible);
			}
			else
			{
				Visible = true;
				Target.SetActive(Visible);
			}
		}
	}
}
