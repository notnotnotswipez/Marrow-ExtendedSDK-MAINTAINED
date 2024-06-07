using UnityEngine;

public class SetGravity : MonoBehaviour
{
	public float y_val;

	private Vector3 _cachedGrav;

	private Vector3 _moonGrav;

	private void Start()
	{
	}

	[ContextMenu("Set Grav Val")]
	public void SetGravityVal()
	{
	}

	private void OnDestroy()
	{
	}
}
