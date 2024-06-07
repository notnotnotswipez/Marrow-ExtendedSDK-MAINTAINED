using UnityEngine;

namespace PathCreation.Examples
{
	[ExecuteInEditMode]
	public class PathPlacer : PathSceneTool
	{
		public GameObject prefab;

		public GameObject holder;

		public float spacing;

		private const float minSpacing = 0.1f;

		private void Generate()
		{
		}

		private void DestroyObjects()
		{
		}

		protected override void PathUpdated()
		{
		}
	}
}
