using UnityEngine;

public class TriggerRespawn : MonoBehaviour
{
	#region Vars/Props
	#endregion

	#region Component
	public void OnTriggerEnter(Collider other)
	{
		var obj = other.gameObject;
		if (!obj.TryGetComponent<Player>(out var ply)) return;

		ply.Spawn();
	}
	#endregion
}
//