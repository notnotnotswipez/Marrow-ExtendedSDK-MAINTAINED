using UnityEngine;
using UnityEngine.AI;

public class PlayerNavigation : MonoBehaviour
{
	[SerializeField]
	private GameObject[] navPoints;

	[SerializeField]
	private int currPoint;

	[SerializeField]
	private float destDelay;

	[SerializeField]
	private NavMeshAgent playerAgent;

	[SerializeField]
	private bool isDrawingPath;

	[SerializeField]
	private Color pathColor;

	private Coroutine playerNavRoutine;
}
