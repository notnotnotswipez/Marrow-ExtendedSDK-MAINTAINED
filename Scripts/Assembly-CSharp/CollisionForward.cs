using UnityEngine;
using UnityEngine.Events;

public class CollisionForward : MonoBehaviour
{
	[SerializeField]
	private UnityEvent<Collision> collisionEnterEvent;

	[SerializeField]
	private UnityEvent<Collision> collisionExitEvent;

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionExit(Collision collision)
	{
	}
}
