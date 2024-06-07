using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class Socket : MarrowBehaviour
	{
		private HashSet<Plug> _hoveredPlugs;

		private List<Plug> _plugStays;

		private List<Plug> _plugExits;

		public Action<Plug> onPlugLockDelegate;

		public Action onPlugUnlockDelegate;

		[Header("Socket")]
		public Grip proxyGrip;

		public float endDistance;

		public float influenceRadius;

		public Transform endTransform;

		public InteractableHost host;

		public Transform cutoffDirection;

		public Plug LockedPlug
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public virtual bool IsClearOnInsert => false;

		public bool IsLocked
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Reset()
		{
		}

		protected virtual void Awake()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void OnPlugEnter(Plug plug)
		{
		}

		protected virtual void OnPlugExit(Plug plug)
		{
		}

		public void Unlock()
		{
		}

		public void Lock(Plug plug)
		{
		}

		public virtual void OnDespawn()
		{
		}
	}
}
