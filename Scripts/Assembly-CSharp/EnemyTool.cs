using System.Collections.Generic;
using SLZ.Bonelab;
using SLZ.Marrow;
using SLZ.Marrow.AI;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.PuppetMasta;
using TMPro;
using UnityEngine;

public class EnemyTool : MonoBehaviour
{
	public enum EToolMode
	{
		INFO = 0,
		AGGRO = 1,
		PATH = 2,
		ROAM = 3,
		CLEAR = 4
	}

	public EToolMode mode;

	public TargetGrip triggerGrip;

	public Transform firePoint;

	public float range;

	public LayerMask collisionLayers;

	public TextMeshPro mainUIPanel;

	public GameObject laserPointer;

	private RaycastHit hitInfo;

	private Rigidbody hitRb;

	public MarrowEntity entity;

	public AIBrain brain;

	public BehaviourBaseNav baseNav;

	public BehaviourOmniwheel omniHaviour;

	public MarrowEntity entityTarg;

	public AIBrain brainTarg;

	public BehaviourBaseNav baseNavTarg;

	public List<Vector3> roamPointList;

	public LineRenderer lineRend;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnHandAttached(Hand hand)
	{
	}

	private void OnHandDetached(Hand hand)
	{
	}

	private void OnHandAttachedUpdate(Hand hand)
	{
	}

	private void InfoUpdate()
	{
	}

	private void AggroUpdate()
	{
	}

	private void PathUpdate()
	{
	}

	private void RoamUpdate()
	{
	}

	private void ClearUpdate()
	{
	}

	private void UpdateUI()
	{
	}

	public void ResetData()
	{
	}

	private void ToggleMode()
	{
	}
}
