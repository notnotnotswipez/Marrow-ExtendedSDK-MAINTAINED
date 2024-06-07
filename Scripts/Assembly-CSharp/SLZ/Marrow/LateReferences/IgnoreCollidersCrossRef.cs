using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.LateReferences
{
	public class IgnoreCollidersCrossRef : MonoBehaviour
	{
		public List<Collider> addedCols;

		public List<Collider> crossRefCols;

		public List<GameObject> colliderParentsList;

		public List<Collider> crossRefSceneCollidersWithinBounds;

		private IgnoreCollidersImportRef ignoreCollidersImportRef;

		public Vector3 colliderBounds;

		public Vector3 colliderBoundsCenter;

		public Collider[] collidersToIgnore;

		public List<Collider> sceneCollidersWithinBounds;

		private LayerMask layerFilter;

		private List<Collider> sceneColliders;

		private List<Collider> collidersToIgnoreList;

		public void IgnoreColsOnLateReferenceLinked()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void CollectCrossSceneColliders()
		{
		}

		private void CollectColliders()
		{
		}

		private void IgnoreSameSceneColliders()
		{
		}

		private void IgnoreDifferentSceneColliders()
		{
		}

		private void DisableCol()
		{
		}

		private void EnableCol()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
