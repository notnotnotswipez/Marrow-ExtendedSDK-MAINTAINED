using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PuppetMasta;
using SLZ.Marrow.AI;
using SLZ.Marrow.Data;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;
using UnityEngine.AI;

namespace SLZ.Bonelab
{
	public class AgentLinkControl : MonoBehaviour
	{
		public enum LinkState
		{
			SEARCHING = 0,
			WAITING = 1,
			LINKING = 2
		}

		[CompilerGenerated]
		private sealed class _003CCoSearchForLink_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public AgentLinkControl _003C_003E4__this;

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
			public _003CCoSearchForLink_003Ed__78(int _003C_003E1__state)
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
		private sealed class _003CCoTriggerLink_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

			private float _003CtriggerTimer_003E5__2;

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
			public _003CCoTriggerLink_003Ed__79(int _003C_003E1__state)
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
		private sealed class _003CCoWaitForOccupation_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

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
			public _003CCoWaitForOccupation_003Ed__85(int _003C_003E1__state)
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
		private sealed class _003CCoClimbBlock_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

			public float obstructionWait;

			private float _003CobstructionTimer_003E5__2;

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
			public _003CCoClimbBlock_003Ed__86(int _003C_003E1__state)
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
		private sealed class _003CCoJump_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

			public float seconds;

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
			public _003CCoJump_003Ed__88(int _003C_003E1__state)
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
		private sealed class _003CCoLaunch_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

			public float linkDuration;

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
			public _003CCoLaunch_003Ed__89(int _003C_003E1__state)
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
		private sealed class _003CCoOmniJumpDown_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float seconds;

			public AgentLinkControl _003C_003E4__this;

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
			public _003CCoOmniJumpDown_003Ed__90(int _003C_003E1__state)
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
		private sealed class _003CCoClimbBars_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

			private int _003CcurrGrab_003E5__2;

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
			public _003CCoClimbBars_003Ed__91(int _003C_003E1__state)
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
		private sealed class _003CCoSlide_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

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
			public _003CCoSlide_003Ed__92(int _003C_003E1__state)
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
		private sealed class _003CCoClimbLedge_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

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
			public _003CCoClimbLedge_003Ed__93(int _003C_003E1__state)
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
		private sealed class _003CCoZipLineDown_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

			private float _003CzipTimeMaxOut_003E5__2;

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
			public _003CCoZipLineDown_003Ed__94(int _003C_003E1__state)
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
		private sealed class _003CCoZipLineUp_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

			private float _003CzipTimeMaxOut_003E5__2;

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
			public _003CCoZipLineUp_003Ed__95(int _003C_003E1__state)
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
		private sealed class _003CCoEscalate_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

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
			public _003CCoEscalate_003Ed__96(int _003C_003E1__state)
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
		private sealed class _003CCoDistCovered_003Ed__97 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

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
			public _003CCoDistCovered_003Ed__97(int _003C_003E1__state)
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
		private sealed class _003CCoCheckLegsFallenState_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

			private float _003CstuckTimer_003E5__2;

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
			public _003CCoCheckLegsFallenState_003Ed__98(int _003C_003E1__state)
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
		private sealed class _003CCoCheckCrabFallenState_003Ed__99 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

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
			public _003CCoCheckCrabFallenState_003Ed__99(int _003C_003E1__state)
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
		private sealed class _003CCoCrabJumpAttempt_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

			private bool _003CisForwDir_003E5__2;

			private float _003CstandUpTimer_003E5__3;

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
			public _003CCoCrabJumpAttempt_003Ed__104(int _003C_003E1__state)
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
		private sealed class _003CCoCrabZip_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

			private float _003CzipTimeMaxOut_003E5__2;

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
			public _003CCoCrabZip_003Ed__105(int _003C_003E1__state)
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
		private sealed class _003CCoDespawnDeadEscalator_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AgentLinkControl _003C_003E4__this;

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
			public _003CCoDespawnDeadEscalator_003Ed__111(int _003C_003E1__state)
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

		private bool isDebugging;

		private bool isDisplayingDist;

		private bool isDebuggingFallenState;

		[Header("Agent Data")]
		[SerializeField]
		private float totalMass;

		[SerializeField]
		private float jointForceMult;

		private float defaultTotalMass;

		public NavMeshAgent navAgent;

		[SerializeField]
		private AIBrain brain;

		public TriggerRefProxy triggerProxy;

		public BehaviourBaseNav baseBehaviour;

		public BehaviourPowerLegs legBehaviour;

		public BehaviourOmniwheel omniBehaviour;

		[SerializeField]
		private BehaviourCrablet crabBehaviour;

		[SerializeField]
		private GameObject frozenCrabJumpTargetObj;

		public PuppetMaster _puppet;

		public LinkState linkState;

		public bool isOnLink;

		public bool isZipping;

		public float agentDot;

		[SerializeField]
		private float yDiff;

		public Spawnable zipStickSpawn;

		public GameObject zipStick;

		public Rigidbody zipGripBody;

		[SerializeField]
		[Header("Link Data")]
		private UnityEngine.Object owner;

		[SerializeField]
		private NavMeshLink currLink;

		[SerializeField]
		private LinkData currLinkData;

		[SerializeField]
		private LinkData prevLinkData;

		[SerializeField]
		private float linkStartTime;

		[SerializeField]
		private float minLinkDupeDuration;

		private float linkVelThresh;

		private Coroutine searchRoutine;

		private Coroutine climbRoutine;

		private Coroutine jumpRoutine;

		private Coroutine launchRoutine;

		private Coroutine climbBarsRoutine;

		private Coroutine slideRoutine;

		private Coroutine climbLedgeRoutine;

		private Coroutine zipRoutine;

		private Coroutine reverseZipRoutine;

		private Coroutine occupiedRoutine;

		private Coroutine distRoutine;

		private Coroutine fallenRoutine;

		private Coroutine escalatorRoutine;

		[SerializeField]
		[Header("Rigidbodies")]
		public Rigidbody headRB;

		[SerializeField]
		public Rigidbody chestRB;

		[SerializeField]
		private Rigidbody leftHandRB;

		[SerializeField]
		private Rigidbody leftElbowRB;

		[SerializeField]
		private Rigidbody rightHandRB;

		[SerializeField]
		private Rigidbody rightElbowRB;

		[SerializeField]
		private Rigidbody leftFootRB;

		[SerializeField]
		private Rigidbody leftKneeRB;

		[SerializeField]
		private Rigidbody rightFootRB;

		[SerializeField]
		private Rigidbody rightKneeRB;

		public Rigidbody[] allRBs;

		[Header("Joints")]
		[SerializeField]
		private ConfigurableJoint headJoint;

		[SerializeField]
		private ConfigurableJoint chestJoint;

		[SerializeField]
		private ConfigurableJoint leftElbowJoint;

		[SerializeField]
		private ConfigurableJoint rightElbowJoint;

		[SerializeField]
		private ConfigurableJoint leftHandJoint;

		[SerializeField]
		private ConfigurableJoint rightHandJoint;

		[SerializeField]
		private ConfigurableJoint leftKneeJoint;

		[SerializeField]
		private ConfigurableJoint rightKneeJoint;

		[SerializeField]
		private ConfigurableJoint leftFootJoint;

		[SerializeField]
		private ConfigurableJoint rightFootJoint;

		private JointDrive kneeDrive;

		private JointDrive footDrive;

		private JointDrive handDrive;

		private JointDrive chestDrive;

		private JointDrive headDrive;

		private int crabletAgentID;

		public TriggerRefProxy playerProxy;

		[Header("Distance Covered")]
		[SerializeField]
		private Vector3 initialPos;

		[SerializeField]
		private float sqrPos;

		[SerializeField]
		private float distTimer;

		private Color agentColor;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CCoSearchForLink_003Ed__78))]
		private IEnumerator CoSearchForLink(float delay = 0f)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoTriggerLink_003Ed__79))]
		private IEnumerator CoTriggerLink()
		{
			return null;
		}

		[ContextMenu("Reset Agent Path")]
		public void ResetAgent()
		{
		}

		public void ResetDistRoutine()
		{
		}

		public void StopDistRoutines()
		{
		}

		private void SetLinkState(LinkState state)
		{
		}

		private void StartLinkByType()
		{
		}

		[IteratorStateMachine(typeof(_003CCoWaitForOccupation_003Ed__85))]
		private IEnumerator CoWaitForOccupation()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoClimbBlock_003Ed__86))]
		private IEnumerator CoClimbBlock(float obstructionWait = 10f)
		{
			return null;
		}

		private void LaunchArm()
		{
		}

		[IteratorStateMachine(typeof(_003CCoJump_003Ed__88))]
		private IEnumerator CoJump(float seconds)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoLaunch_003Ed__89))]
		private IEnumerator CoLaunch(float linkDuration)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoOmniJumpDown_003Ed__90))]
		private IEnumerator CoOmniJumpDown(float seconds)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoClimbBars_003Ed__91))]
		private IEnumerator CoClimbBars()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoSlide_003Ed__92))]
		private IEnumerator CoSlide()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoClimbLedge_003Ed__93))]
		private IEnumerator CoClimbLedge()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoZipLineDown_003Ed__94))]
		private IEnumerator CoZipLineDown()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoZipLineUp_003Ed__95))]
		private IEnumerator CoZipLineUp()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoEscalate_003Ed__96))]
		private IEnumerator CoEscalate()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoDistCovered_003Ed__97))]
		private IEnumerator CoDistCovered()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoCheckLegsFallenState_003Ed__98))]
		private IEnumerator CoCheckLegsFallenState()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoCheckCrabFallenState_003Ed__99))]
		private IEnumerator CoCheckCrabFallenState()
		{
			return null;
		}

		private void OnProxyEnter(TriggerRefProxy proxy)
		{
		}

		public void DetachDownZip()
		{
		}

		public void DetachUpZip()
		{
		}

		private void CreateJumpTarget()
		{
		}

		[IteratorStateMachine(typeof(_003CCoCrabJumpAttempt_003Ed__104))]
		private IEnumerator CoCrabJumpAttempt()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoCrabZip_003Ed__105))]
		private IEnumerator CoCrabZip()
		{
			return null;
		}

		private void FailLink()
		{
		}

		private void CompleteLink()
		{
		}

		private void ReleaseLinkAndJoints()
		{
		}

		private void StopAllLinkRoutines()
		{
		}

		private void OnDeath()
		{
		}

		[IteratorStateMachine(typeof(_003CCoDespawnDeadEscalator_003Ed__111))]
		private IEnumerator CoDespawnDeadEscalator()
		{
			return null;
		}

		private void DestroyHandJoints()
		{
		}

		private void DestroyLeftArmJoints()
		{
		}

		private void DestroyRightArmJoints()
		{
		}

		private void DestroyArmJoints()
		{
		}

		private void DestroyLegJoints()
		{
		}

		private void DestroyAllJoints()
		{
		}

		private void DestroyHeadJoint()
		{
		}

		private void DestroyChestJoint()
		{
		}

		private bool CheckYDist(float maxVal)
		{
			return false;
		}

		public void StopAllRoutinesAndDisable()
		{
		}

		[ContextMenu("GetAgentRefs")]
		public void GetAgentRefs()
		{
		}

		[ContextMenu("GetAllRigidbodies")]
		public void GetAllRigidbodies()
		{
		}

		[ContextMenu("GetTotalMass")]
		public void GetTotalMass()
		{
		}

		public void OnDrawGizmos()
		{
		}
	}
}
