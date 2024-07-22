using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Barracuda;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BarracudaModelManager_OLD
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRun_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public BarracudaModelManager_OLD _003C_003E4__this;

			public CancellationTokenSource cancelToken;

			private IEnumerator _003Cit_003E5__2;

			private int _003Ccounter_003E5__3;

			private int _003Cit_counter_003E5__4;

			private Tensor _003Coutput_003E5__5;

			private UniTask.Awaiter _003C_003Eu__1;

			private int _003Csim_update_counter_003E5__6;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		public GameObject agentPrefab;

		public GameObject area;

		public bool handle_placement;

		public int requested_rows;

		public float spacing;

		[HideInInspector]
		public bool exitWorker;

		public bool do_sim_update;

		public NNModel srcModel;

		public int nb_agents;

		public int nb_network_slices;

		public int nb_sim_steps;

		public int actionmask_size;

		public Transform target;

		public bool warm;

		public string[] string_obs_names;

		public string[] output_names;

		public Dictionary<string, Tensor> tensor_observation_dict;

		public Dictionary<string, float[]> float_observation_dict;

		public Dictionary<string, Tensor> tensor_action_dict;

		private float[] accept_all_action_mask;

		[HideInInspector]
		public int batch_size;

		public InferenceAgent[] agent_list;

		private Model model;

		private IWorker engine;

		public int nb_agents_collected;

		private int fixed_counter;

		private void FixedUpdate()
		{
		}

		public void AcceptAllActionMask()
		{
		}

		public void WarmStartModelManager(ModelManagerConfig bmmConfig)
		{
		}

		private void InitDictionaries()
		{
		}

		public void WarmUp()
		{
		}

		[AsyncStateMachine(typeof(_003CRun_003Ed__31))]
		public UniTaskVoid Run(CancellationTokenSource cancelToken)
		{
			return default(UniTaskVoid);
		}

		public void Dispose()
		{
		}
	}
}
