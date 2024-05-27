using UnityEngine;

public class Game : MonoBehaviour
{
	#region Vars/Props
	public static Game Instance { get; private set; }

    public Transform transformCurrentSpawnPlayer;
	#endregion

	#region Component
	private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

	private void Start()
	{
		if (transformCurrentSpawnPlayer == null)
			Debug.LogError($"[Game] Doesn't find transformCurrentSpawnPlayer");
	}
	#endregion
}