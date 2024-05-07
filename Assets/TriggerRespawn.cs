using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRespawn : MonoBehaviour
{
	public Transform spawnPoint;

	public void OnTriggerEnter(Collider other)
	{
		if (spawnPoint == null) return;

		var obj = other.gameObject;
		if (obj.tag.ToLower() != "player") return;

		var charController = obj.GetComponent<CharacterController>();
		if (charController == null) return;

		charController.enabled = false;
		obj.transform.position = spawnPoint.position;
		charController.enabled = true;
	}
}
