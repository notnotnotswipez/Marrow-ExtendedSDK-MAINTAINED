using Barracuda;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.MLAgents
{
	public class BarracudaModelManager : MonoBehaviour
	{
		public class AgentBackFill : UnityEvent<int, int>
		{
			public AgentBackFill()
			{
				
			}
		}

		[CompilerGenerated]
		private sealed class _003CRun_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BarracudaModelManager _003C_003E4__this;

			private int _003Ccounter_003E5__2;

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
			public _003CRun_003Ed__59(int _003C_003E1__state)
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
		private sealed class _003CWaitForAllOutputs_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Dictionary<string, Tensor> outputs;

			private Dictionary<string, Tensor>.ValueCollection.Enumerator _003C_003E7__wrap1;

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
			public _003CWaitForAllOutputs_003Ed__62(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
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
		private sealed class _003CSlicedInference_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BarracudaModelManager _003C_003E4__this;

			private int _003Ccounter_003E5__2;

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
			public _003CSlicedInference_003Ed__64(int _003C_003E1__state)
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
		private sealed class _003CDoSimUpdate_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BarracudaModelManager _003C_003E4__this;

			private int _003CsimUpdateCounter_003E5__2;

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
			public _003CDoSimUpdate_003Ed__67(int _003C_003E1__state)
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
		private sealed class _003CCheckForLateInferenceExit_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BarracudaModelManager _003C_003E4__this;

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
			public _003CCheckForLateInferenceExit_003Ed__69(int _003C_003E1__state)
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

		public static List<BarracudaModelManager> Instances;

		[Tooltip("Config holding values for Model Manager")]
		[Header("Model/Inference Pipeline Specific")]
		public ModelManagerConfig bmmConfig;

		[Tooltip("The neural network to do inference with")]
		public NNModel srcModel;

		[Tooltip("Indicates if model, engine, and dicts are fully ready")]
		public bool warm;

		private Model _model;

		private IWorker _engine;

		[Tooltip("Indicates if model and engine need to be loaded/created")]
		private bool _needsInit;

		public UnityEvent agentTakeActionEvent;

		public UnityEvent agentCollectObservationsEvent;

		public AgentBackFill agentBackFill;

		[Header("Inference Agent Specific")]
		[Tooltip("How many agents the BMM is responsible for managing")]
		public int nbAgents;

		private List<int> _availableInds;

		[Header("BMM Data Specific")]
		public Dictionary<string, Tensor> TensorObservationDict;

		public Dictionary<string, float[]> FloatObservationDict;

		public Dictionary<string, Tensor> TensorActionDict;

		private List<InferenceAgent> _agentList;

		[Tooltip("Fills public arrays that can be used for quick debugging")]
		public bool useDbgArrays;

		[Tooltip("Public array containing all agent's inputs")]
		public float[] fullDbgInput;

		[Tooltip("Indicates if tensor dictionaries need to be re-instantiated")]
		public bool reInitDicts;

		[Tooltip("Size of action mask (this is required for discrete actions)")]
		public int actionmaskSize;

		[Tooltip("Names of the different outputs to reference when agents are trying to get their actions")]
		public string[] outputNames;

		[Tooltip("Size of input for nn")]
		public int observationSize;

		private int _batchSize;

		private Tensor _output;

		private Dictionary<string, Tensor> _outputDict;

		private Tensor _actionMaskTensor;

		private float[] _actionMask;

		[Tooltip("How many layers to operate on per BMM output tick")]
		public int nbNetworkSlices;

		[Tooltip("Whether to allow for extra steps in the decision request pipeline for the simulation to update before next observation is made")]
		public bool doSimUpdate;

		[Tooltip("How many steps to use that updates the sim state before next observation is made")]
		public int nbSimSteps;

		[Tooltip("Used for breaking out of inference loop")]
		public bool exitWorker;

		[Tooltip("Indicates if the inference coroutine is running")]
		public bool running;

		private IEnumerator _engineIterator;

		private void Awake()
		{
		}

		public void InitBMM()
		{
		}

		public void InitFromConfig(ModelManagerConfig bmmConfig)
		{
		}

		public void WarmStartFromConfig(ModelManagerConfig bmmConfig)
		{
		}

		public void WarmUp()
		{
		}

		public void StartManager()
		{
		}

		public void StopManager()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		public void ConnectAgentToBmm(GameObject agent, int agentId)
		{
		}

		public void RegisterAgent(InferenceAgent agent, ulong pooleeId)
		{
		}

		public void UnRegisterAgent(InferenceAgent agent, ulong pooleeId)
		{
		}

		public void InitDictionaries()
		{
		}

		private void InitializeObservationDict()
		{
		}

		private void IngestAgentObservations(int id, float[] observations, string observationString)
		{
		}

		private void AcceptAllActionMask()
		{
		}

		public void WipeEverything()
		{
		}

		public void DisposeDataOnly()
		{
		}

		private void TensorDisposal()
		{
		}

		private void DisposeObservationTensors()
		{
		}

		private void DisposeActionTensors()
		{
		}

		private void DisposeOutputTensor()
		{
		}

		private void DisposeEngine()
		{
		}

		private void ClearAllDictionaries()
		{
		}

		[IteratorStateMachine(typeof(_003CRun_003Ed__59))]
		private IEnumerator Run()
		{
			return null;
		}

		private void QueryModelOutput()
		{
		}

		private Dictionary<string, Tensor> QueryModelOutputs()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitForAllOutputs_003Ed__62))]
		private IEnumerator WaitForAllOutputs(Dictionary<string, Tensor> outputs)
		{
			return null;
		}

		private void FillTensorActions()
		{
		}

		[IteratorStateMachine(typeof(_003CSlicedInference_003Ed__64))]
		private IEnumerator SlicedInference()
		{
			return null;
		}

		private void AgentCollectSignal()
		{
		}

		private void SendActionsToAgents()
		{
		}

		[IteratorStateMachine(typeof(_003CDoSimUpdate_003Ed__67))]
		private IEnumerator DoSimUpdate()
		{
			return null;
		}

		private bool CheckForEarlyInferenceExit()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CCheckForLateInferenceExit_003Ed__69))]
		private IEnumerator CheckForLateInferenceExit()
		{
			return null;
		}
	}
}
