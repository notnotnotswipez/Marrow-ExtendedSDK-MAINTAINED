using System.Collections.Generic;
using UnityEngine;

namespace BitOperators
{
	public class DrawZCurveTester : MonoBehaviour
	{
		public int layer;

		public bool draw;

		public bool simpleMode;

		public int rootResolution;

		public int nbLayers;

		public GameObject textParent;

		private List<GameObject> _textList;

		private Vector3 _position;

		private int CalculateFinalResolution()
		{
			return 0;
		}

		private static int GetOctantSizeAtLayer(int layer)
		{
			return 0;
		}

		private int TotalCellsAtLayer(int layer)
		{
			return 0;
		}

		[ContextMenu("Clear Text")]
		public void ClearText()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
