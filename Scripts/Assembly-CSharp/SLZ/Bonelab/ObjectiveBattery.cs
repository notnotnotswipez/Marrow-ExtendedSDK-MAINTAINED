using System;
using SLZ.Marrow;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ObjectiveBattery : MonoBehaviour
	{
		public float charge;

		public TMP_Text chargeText;

		public Grip grip;

		private float energyPerc;

		[SerializeField]
		private GameObject energyBarObj;

		private Vector3 startBar;

		[SerializeField]
		private Vector3 endBar;

		public static Action OnBattteryGrabbed;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateCharge(float energy)
		{
		}

		public void DecrementCharge(float energy)
		{
		}

		private void OnGrab(Hand hand)
		{
		}
	}
}
