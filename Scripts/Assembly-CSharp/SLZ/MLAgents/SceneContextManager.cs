using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.MLAgents;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class SceneContextManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSelectAndLoadScene_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneContextManager _003C_003E4__this;

			private AsyncOperation _003CasyncOp_003E5__2;

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
			public _003CSelectAndLoadScene_003Ed__18(int _003C_003E1__state)
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

		public string[] allSceneContexts;

		public string[] desiredSceneContexts;

		public string[] sceneNames;

		protected Dictionary<string, float[]> paramDict;

		public int sceneInd;

		public string currentScene;

		protected int sceneCounter;

		private SceneContextManager thisManager;

		protected static int nbContexts;

		public string currentContext;

		public Dictionary<string, string> contextSceneNamesDict;

		public float[] currentParams;

		public bool useCur;

		[HideInInspector]
		public EnvironmentParameters envParams;

		protected event Action sceneLoaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CSelectAndLoadScene_003Ed__18))]
		public IEnumerator SelectAndLoadScene()
		{
			return null;
		}

		[ContextMenu("Increment Scene")]
		public void IncrementScene()
		{
		}
	}
}
