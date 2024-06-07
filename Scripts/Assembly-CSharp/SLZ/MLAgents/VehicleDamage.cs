using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class VehicleDamage : MonoBehaviour
	{
		public enum WheelDamage
		{
			Off = 0,
			Visual = 1,
			Mechanical = 2
		}

		private struct originalMeshVerts
		{
			public Vector3[] meshVerts;
		}

		[CompilerGenerated]
		private sealed class _003CCoRepair_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VehicleDamage _003C_003E4__this;

			private float _003CendRepair_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoRepair_003Ed__27(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public object Current { get; }

			object IEnumerator.Current => Current;

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[SerializeField]
		private float health;

		[SerializeField]
		private float minCollisionForce;

		[SerializeField]
		private AudioClip[] crashClips;

		public bool useDamage;

		public WheelDamage wheelDamage;

		public float wheelDamageRadius;

		public float wheelDamageMultiplier;

		private originalMeshVerts[] originalMeshData;

		public MeshFilter[] deformableMeshFilters;

		public LayerMask damageFilter;

		public float randomizeVertices;

		public float damageRadius;

		private float minimumVertDistanceForDamagedMesh;

		public bool repairNow;

		public bool repaired;

		public float maximumDamage;

		public float damageMultiplier;

		private Vector3 localVector;

		private Quaternion rot;

		private void Awake()
		{
		}

		private void InitDamage()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void LoadOriginalMeshData()
		{
		}

		private void DeformMesh(Mesh mesh, Vector3[] originalMesh, Collision collision, float cos, Transform meshTransform, Quaternion rot)
		{
		}

		[ContextMenu("Repair")]
		public void StartRepair()
		{
		}

		[IteratorStateMachine(typeof(_003CCoRepair_003Ed__27))]
		private IEnumerator CoRepair()
		{
			return null;
		}

		public void Repair()
		{
		}
	}
}
