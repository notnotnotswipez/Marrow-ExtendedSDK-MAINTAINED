using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GachaCapsuleSpawner : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSpawnGachas_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CSpawnGachas_003Ed__11(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnGacha_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[SerializeField]
		private Spawnable gacha;

		private List<SpawnableCrate> cratesToSpawn;

		private bool usedSpawnAll;

		private static PlayerUnlocks u => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPalletAdded(string palletBarcode)
		{
		}

		public void UNLOCKALL()
		{
		}

		public void RELOCKALL()
		{
		}

		public void SPAWNUNLOCKGACHA()
		{
		}

		[IteratorStateMachine(typeof(_003CSpawnGachas_003Ed__11))]
		private IEnumerator SpawnGachas()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSpawnGacha_003Ed__12))]
		private UniTaskVoid SpawnGacha(SpawnableCrate crateToLink)
		{
			return default(UniTaskVoid);
		}
	}
}
