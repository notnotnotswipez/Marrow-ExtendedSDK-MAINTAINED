using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace SLZ.Interaction
{
	public class InteractableHostManager : MonoBehaviour
	{
		public InteractableHost[] hosts;

		public Action<InteractableHost, Hand> onHandAttached;

		public Action<InteractableHost, Hand> onHandDetached;

		[HideInInspector]
		public List<InteractableHost> grabbedHosts;

		public float TotalMass
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		private void Reset()
		{
		}

		private void Start()
		{
		}

		public void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		public void OnDetachedHand(InteractableHost host, Hand hand)
		{
		}

		public void ForceDetachAll()
		{
		}

		public void EnableCollisonAll()
		{
		}

		public void DisableCollisionAll()
		{
		}

		public void EnableInteractionAll()
		{
		}

		public void DisableInteractionAll()
		{
		}
	}

#if UNITY_EDITOR
	[CustomEditor(typeof(InteractableHostManager))]
	[DisallowMultipleComponent]
	public class InteractableHostManagerEditor : Editor 
	{
	    public override void OnInspectorGUI()
	    {
			InteractableHostManager behaviour = (InteractableHostManager)target;

    	    if(GUILayout.Button("Collect InteractableHosts"))
        	{
				InteractableHost[] hosts = behaviour.GetComponentsInChildren<InteractableHost>(true);
				List<InteractableHost> validHosts = new List<InteractableHost>();
				foreach(InteractableHost host in hosts)
				{
					if(host.GetComponentInParent<InteractableHostManager>() == behaviour)
					{
						host.manager = behaviour;
						validHosts.Add(host);
					}
				}
				behaviour.hosts = validHosts.ToArray();
#if UNITY_EDITOR
				EditorUtility.SetDirty(behaviour);
#endif
        	}
	
        	DrawDefaultInspector();
	    }
	}
#endif
}
