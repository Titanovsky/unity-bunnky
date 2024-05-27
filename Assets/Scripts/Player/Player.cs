using UnityEngine;

public class Player : MonoBehaviour
{
	#region Vars/Props
	private CharacterController charController;
	private Game game;

	private Quaternion rotDefault = new Quaternion(0, 0, 0, 0);
	#endregion

	#region Logic
	public void SetPosition(Vector3 pos)
	{
		if (charController == null) return;

		charController.enabled = false;
		transform.position = pos;
		charController.enabled = true;
	}

	public void SetPosition(Vector3 pos, Quaternion rot)
	{
		SetPosition(pos);
		SetRotation(rot);
	}

	public void SetPosition(Transform transform)
	{
		SetPosition(transform.position, transform.rotation);
	}

	public void SetRotation(Quaternion rotation)
	{
		transform.rotation = rotation;
	}

	public void Spawn()
	{
		if (game == null) return;

		SetPosition(game.transformCurrentSpawnPlayer);
	}
	#endregion

	#region Component
	private void Start()
	{
		if (!TryGetComponent(out charController))
			Debug.LogError($"[Player] Doesn't find CharacterController");

		game = Game.Instance;
		if (game == null)
			Debug.LogError($"[Player] Doesn't find Game.Instance");
	}
	#endregion
}