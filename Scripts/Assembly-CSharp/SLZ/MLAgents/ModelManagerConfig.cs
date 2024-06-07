using Barracuda;
using UnityEngine;

namespace SLZ.MLAgents
{
	[CreateAssetMenu(fileName = "BarracudaModelManagerConfig", menuName = "ModelManagerConfigs/BMMConfigs", order = 1)]
	public class ModelManagerConfig : ScriptableObject
	{
		[SerializeField]
		private NNModel srcModel;

		[SerializeField]
		private Transform initialTarget;

		[SerializeField]
		private string[] output_names;

		[SerializeField]
		private int action_mask_size;

		[SerializeField]
		private int nb_network_slices;

		[SerializeField]
		private int nb_sim_steps;

		[SerializeField]
		private bool do_sim_update;

		[SerializeField]
		private bool inference_switch;

		[SerializeField]
		private int max_nb_agents;

		public NNModel SrcModel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform InitialTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string[] Output_names
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Action_mask_size
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Nb_network_slices
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Nb_sim_steps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Max_nb_agents
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool Do_sim_update
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Inference_switch
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
