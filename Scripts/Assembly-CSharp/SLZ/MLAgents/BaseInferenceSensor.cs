using Barracuda;
using Unity.MLAgents.Sensors;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BaseInferenceSensor : MonoBehaviour
	{
		public string obs_name;

		public Tensor obs;

		public int nb_stacked_obs;

		public int observation_size;

		public float[] input_data;

		public float[] current_input;

		public float[] new_stack;

		public GameObject referencePoint;

		public int sensorInd;

		public int offset;

		public virtual void Get()
		{
		}

		public virtual void Send(BarracudaModelManagerMono cuda_manager, int agent_number)
		{
		}

		public virtual void Send(VectorSensor sensor)
		{
		}
	}
}
