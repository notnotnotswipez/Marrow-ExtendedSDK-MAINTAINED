using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace SLZ.Bonelab
{
	public class NarrativeManager : MonoBehaviour
	{
		[Header("Active Narrative State, do not set in inspector")]
		public NarrativeState activeNState;

		[SerializeField]
		private PlayableDirector activeDirector;

		[SerializeField]
		private NarrativeState.HoldState activeHoldState;

		[SerializeField]
		[Header("Active Interupt Director")]
		private PlayableDirector interuptDirector;

		[SerializeField]
		private NarrativeState[] narrativeStates;

		[SerializeField]
		private ActionDirector[] actionDirectors;

		private Dictionary<string, ActionDirector> actionDictionary;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}

		private void OnPlayableDirectorStopped(PlayableDirector stoppedDirector)
		{
		}

		private void OnStateChanged(NarrativeState nState, PlayableDirector director)
		{
		}

		public void PlayerInteruptAction(string playerAction)
		{
		}

		[ContextMenu("TestSuicideAction")]
		public void TestInterupt()
		{
		}

		[ContextMenu("GetAllNarrativeStates")]
		public void GetAllHoldStates()
		{
		}
	}
}
