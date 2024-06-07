using UnityEngine;

namespace SLZ.Bonelab
{
	public class GunHeat : MonoBehaviour
	{
		[SerializeField]
		private Gun gun;

		[SerializeField]
		private Material barrelMat;

		[GradientUsage(true)]
		[SerializeField]
		private Gradient heatGradient;

		[SerializeField]
		private float shotIncrement;

		[SerializeField]
		private float coolTime;

		private float heatValue;

		private float timer;

		private bool updateEmission;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void OnFire()
		{
		}

		private void UpdateHeat(float value)
		{
		}
	}
}
