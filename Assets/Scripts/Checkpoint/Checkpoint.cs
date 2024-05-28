using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{
	#region Vars/Props
	[SerializeField] private Text text;

    private CheckpointModel model;
	private CheckpointView view;
	private CheckpointModelView modelView;
	#endregion

	#region Logic
	public void Init()
	{
		model = new();
		view = new();
		modelView = new();
	}

	public void CheckStability()
	{
		if (text == null)
			Debug.LogError($"[Checkpoint] (Text) text is null");
	}
	#endregion

	#region Component
	private void Start()
    {
		Init();
		CheckStability();
	}
	#endregion
}