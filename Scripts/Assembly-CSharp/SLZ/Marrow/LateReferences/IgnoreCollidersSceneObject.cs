using UnityEngine;

namespace SLZ.Marrow.LateReferences
{
	public class IgnoreCollidersSceneObject : MonoBehaviour
	{
		[SerializeField]
		private IgnoreCollidersImportReference importedCrossRef;

		private void OnEnable()
		{
		}

		private void IgnoreDifferentSceneColliders()
		{
		}
	}
}
