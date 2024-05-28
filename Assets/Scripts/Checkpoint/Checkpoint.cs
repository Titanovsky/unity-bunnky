using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{
	#region Vars/Props
	[SerializeField] private Text _text;
	#endregion

	#region Logic
	public void Init()
	{
	}

	public void CheckStability()
	{
		if (_text == null)
			Debug.LogError($"[Checkpoint] (Text) text is null");
	}
	#endregion

	#region Component
	private void Start()
    {
		CheckStability();
		Init();
	}
	#endregion
}