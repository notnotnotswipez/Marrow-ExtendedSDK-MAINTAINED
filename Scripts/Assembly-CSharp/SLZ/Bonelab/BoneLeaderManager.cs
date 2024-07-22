using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Data;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class BoneLeaderManager : MonoBehaviour
	{
		public enum LeaderMode
		{
			ALL_USER_DATA = 0,
			SINGLE_DATA = 1
		}

		private enum SteamFilter
		{
			FRIENDS = 0,
			USER = 1,
			TOP = 2
		}

		[CompilerGenerated]
		private sealed class _003CCoWaitAndQuery_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BoneLeaderManager _003C_003E4__this;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoWaitAndQuery_003Ed__63(int _003C_003E1__state)
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

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CCoQueryTimeout_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BoneLeaderManager _003C_003E4__this;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoQueryTimeout_003Ed__65(int _003C_003E1__state)
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

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSteam_QueryData_003Ed__66 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public BoneLeaderManager _003C_003E4__this;

			private TaskAwaiter<Leaderboard?> _003C_003Eu__1;

			private TaskAwaiter<LeaderboardEntry[]> _003C_003Eu__2;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSubmitScoreToBoard_003Ed__67 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public BoneLeaderData data;

			public int score;

			public BoneLeaderManager _003C_003E4__this;

			private TaskAwaiter<Leaderboard?> _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		public LeaderMode leaderMode;

		[Header("LEADERBOARD DATA")]
		[SerializeField]
		private List<BoneLeaderData> allLeaderDataList;

		public BoneLeaderData currData;

		[Header("OCULUS USER DATA")]
		[SerializeField]
		[Space(20f)]
		private ulong myID;

		[SerializeField]
		private string myOculusID;

		[SerializeField]
		[Header("STEAM USER DATA")]
		private string steamName;

		[SerializeField]
		private SteamId steamID;

		[SerializeField]
		private Leaderboard board;

		[SerializeField]
		private SteamFilter steamFilter;

		[Header("PREFABS")]
		[SerializeField]
		private GameObject entryPrefab;

		[SerializeField]
		private GameObject userEntryPrefab;

		[Header("UI DISPLAY")]
		public bool allowExitButton;

		[SerializeField]
		private bool isCurrentUser;

		[SerializeField]
		private bool displayPanel;

		[SerializeField]
		private List<GameObject> entryObjectList;

		[SerializeField]
		private GameObject leaderboardEntryParent;

		[SerializeField]
		private bool isAltHighPanel;

		[SerializeField]
		private TMP_Text text_TitleBoard;

		[SerializeField]
		private TMP_Text text_TitleKey;

		[SerializeField]
		private TMP_Text text_ID_Rank_Key;

		[SerializeField]
		private TMP_Text text_ScoreKey;

		[SerializeField]
		private Button button_Filter;

		[SerializeField]
		private Button button_StartAt;

		[SerializeField]
		private TMP_Text startAtButtonText;

		[SerializeField]
		private TMP_Text filterButtonText;

		[SerializeField]
		private Button button_Exit;

		[SerializeField]
		private TMP_Text currPageText;

		[SerializeField]
		private TMP_Text totalPageText;

		[SerializeField]
		private GameObject pageButtonsObj;

		[SerializeField]
		private GameObject pageDownButtonObj;

		[SerializeField]
		private GameObject pageUpButtonObj;

		[SerializeField]
		private TMP_Text text_InternetRequired;

		private int maxEntriesPerPage;

		private int currIndex;

		private int currentPage;

		private int totalPages;

		[HideInInspector]
		public UnityEvent onDataComplete;

		[SerializeField]
		private Transform altLocation;

		private Coroutine timeOutRoutine;

		private void Awake()
		{
		}

		private void PassedEntitlements()
		{
		}

		public void InitializeDisplay()
		{
		}

		private void UpdatePages()
		{
		}

		public void FocusBoardAtIndex(int i)
		{
		}

		public void FocusExplicitLeaderboard(BoneLeaderData data)
		{
		}

		public void ReturnToUserDisplay()
		{
		}

		public void PageUp()
		{
		}

		public void PageDown()
		{
		}

		public void UpdateDisplayState()
		{
		}

		public void ToggleFilterType()
		{
		}

		public void ToggleStartAt()
		{
		}

		public void ToggleAllButtons(bool enable)
		{
		}

		[ContextMenu("DestroyCurrentEntries")]
		public void DestroyCurrentEntries()
		{
		}

		public void GetUserLeaderboardData(int index)
		{
		}

		public void GetUserLeaderboardPage()
		{
		}

		private void CreateBlankUserEntry()
		{
		}

		private void CreateBlankExplicitEntry()
		{
		}

		[ContextMenu("TeleportToAlt")]
		public void TeleportToAltLocation()
		{
		}

		public void ToggleConnectionText(bool enable)
		{
		}

		public void SubmitLeaderboardScore(uint score)
		{
		}

		[IteratorStateMachine(typeof(_003CCoWaitAndQuery_003Ed__63))]
		private IEnumerator CoWaitAndQuery()
		{
			return null;
		}

		public void QueryCurrentData()
		{
		}

		[IteratorStateMachine(typeof(_003CCoQueryTimeout_003Ed__65))]
		private IEnumerator CoQueryTimeout(BoneLeaderData data)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSteam_QueryData_003Ed__66))]
		public void Steam_QueryData()
		{
		}

		[AsyncStateMachine(typeof(_003CSubmitScoreToBoard_003Ed__67))]
		public void SubmitScoreToBoard(BoneLeaderData data, int score)
		{
		}
	}
}
