using UnityEngine;

namespace SLZ.VFX
{
	[RequireComponent(typeof(LineRenderer))]
	public class DrawLinesFromArray : MonoBehaviour
	{
		[SerializeField]
		private LineRenderer liner;

		[SerializeField]
		public GameObject[] Points;

		private bool rendered;

		private void CheckArray()
		{
		}

		private void Awake()
		{
		}

		public void UpdateLines()
		{
		}

		private void OnWillRenderObject()
		{
		}

		private void Update()
		{
		}
	}
}
