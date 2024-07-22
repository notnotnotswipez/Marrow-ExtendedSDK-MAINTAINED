using System.Collections.Generic;
using SLZ.Marrow;
using SLZ.Marrow.Combat;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
{
	public class SixSidedCrate : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		[Space(2f)]
		[Header("IMPACT")]
		[Tooltip("Can be damaged by physical impacts")]
		public bool damageFromImpact;

		[Tooltip("Modifier multiplier to collision")]
		public float mod_Impact;

		[Tooltip("Modifier multiplier for Feet")]
		public float mod_Impact_Player;

		[Tooltip("Threshold of impact magnitude required to damage")]
		public float thr_Impact;

		[Space(15f)]
		[Header("ATTACKED")]
		[Tooltip("Can be damaged by attacks")]
		public bool damageFromAttack;

		[Tooltip("Modifier multiplier to attack damage")]
		public float mod_Attack;

		[Space(15f)]
		[Header("SIDES & Health")]
		public GameObject[] sides;

		public GameObject[] spawnSides;

		public float max_sideHealth;

		private float[] cur_sideHealth;

		public int req_hit;

		private int[] req_hits;

		public bool canOverDamage;

		public bool nonSixSided;

		private Vector3 vel;

		private Vector3 ang_vel;

		[Header("DESTRUCTION")]
		[Space(15f)]
		public Transform fx_Audio;

		private ImpactSFX impactSFX;

		private SimpleTimeDestroy impactSRC_Destroy;

		private Dictionary<int, List<Collider>> sideCols;

		private InteractableHost hnd_Host;

		private void Awake()
		{
		}

		public void Start()
		{
		}

		private void SETSTARTS()
		{
		}

		public void OnCollisionEnter(Collision impact)
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		public void DAMAGE_SIDE(int side, float damage, bool stabbed = false)
		{
		}

		public void DETATCH_SIDE(int side)
		{
		}

		private void DESTROYBOX()
		{
		}

		public void AudioChild()
		{
		}

		private void RemoveHands()
		{
		}
	}
}
