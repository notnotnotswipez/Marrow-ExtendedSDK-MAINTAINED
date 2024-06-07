using UnityEngine;

namespace SLZ.MLAgents
{
	public class LPPV_CarSelection : MonoBehaviour
	{
		public enum CarType
		{
			Sedan = 0,
			Sports = 1,
			Utility = 2,
			Bus = 3
		}

		public static CarType currentCarType;

		[SerializeField]
		private GameObject nextButton;

		[SerializeField]
		private GameObject prevButton;

		[SerializeField]
		private Camera cam;

		private int currentCar;

		private void CheckStatus()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SelectCar()
		{
		}
	}
}
