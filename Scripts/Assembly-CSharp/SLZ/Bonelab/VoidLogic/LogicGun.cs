using System;
using Cysharp.Threading.Tasks;
using SLZ.Marrow;
using SLZ.Marrow.Audio;
using SLZ.Marrow.VoidLogic;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	public class LogicGun : MonoBehaviour
	{
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

		private UniTask ShowNodeInfo(RaycastHit hitInfo)
		{
			return default(UniTask);
		}

		private UniTask ShowSubgraph(RaycastHit hitInfo)
		{
			return default(UniTask);
		}

		private UniTask HideSubgraph(RaycastHit hitInfo)
		{
			return default(UniTask);
		}

		private bool _cycleSelectModes()
		{
			return default(bool);
		}

		[ContextMenu("Show All Subgraphs")]
		private void ShowAllSubgraphs()
		{
		}

		[ContextMenu("Hide All Subgraphs")]
		private void HideAllSubgraphs(bool force = false)
		{
		}

		public LogicGun()
		{
		}

		public TargetGrip triggerGrip;

		public Transform firePoint;

		public float range;

		public TextMeshPro mainUIPanel;

		public GameObject laserPointer;

		public AudioClip[] chargeSFX;

		public AudioClip[] modeSFX;

		public VoidLogicToolSettings toolSettings;

		private ManagedAudioPlayer _mapCharge;

		private ManagedAudioPlayer _mapMode;

		private LogicGunMode _gunMode;

		private GameObject _probeRoot;
	}
}
