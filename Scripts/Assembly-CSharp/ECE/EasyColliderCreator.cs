using System.Collections.Generic;
using UnityEngine;

namespace ECE
{
	public class EasyColliderCreator
	{
		private struct BestFitSphere
		{
			public Vector3 Center;

			public float Radius;

			public BestFitSphere(Vector3 center, float radius)
			{
				this.Center = Vector3.down;
				this.Radius = 1f;
			}
		}

		private BestFitSphere CalculateBestFitSphere(List<Vector3> localVertices)
		{
			return default(BestFitSphere);
		}

		public BoxColliderData CalculateBox(List<Vector3> worldVertices, Transform attachTo, bool isRotated = false)
		{
			return null;
		}

		public BoxColliderData CalculateBoxLocal(List<Vector3> vertices)
		{
			return null;
		}

		public CapsuleColliderData CalculateCapsuleBestFit(List<Vector3> worldVertices, Transform attachTo, bool isRotated)
		{
			return null;
		}

		public CapsuleColliderData CalculateCapsuleBestFitLocal(List<Vector3> localVertices)
		{
			return null;
		}

		public CapsuleColliderData CalculateCapsuleMinMax(List<Vector3> worldVertices, Transform attachTo, CAPSULE_COLLIDER_METHOD method, bool isRotated)
		{
			return null;
		}

		public CapsuleColliderData CalculateCapsuleMinMaxLocal(List<Vector3> localVertices, CAPSULE_COLLIDER_METHOD method)
		{
			return null;
		}

		public MeshColliderData CalculateCylinderCollider(List<Vector3> worldVertices, Transform attachTo, int numberOfSides = 12, CYLINDER_ORIENTATION orientation = CYLINDER_ORIENTATION.Automatic, float cylinderOffset = 0f)
		{
			return null;
		}

		public MeshColliderData CalculateCylinderColliderLocal(List<Vector3> vertices, int numberOfSides = 12, CYLINDER_ORIENTATION orientation = CYLINDER_ORIENTATION.Automatic, float cylinderOffset = 0f)
		{
			return null;
		}

		public MeshColliderData CalculateMeshColliderQuickHullLocal(List<Vector3> localVertices)
		{
			return null;
		}

		public SphereColliderData CalculateSphereBestFit(List<Vector3> worldVertices, Transform attachTo)
		{
			return null;
		}

		public SphereColliderData CalculateSphereBestFitLocal(List<Vector3> localVertices)
		{
			return null;
		}

		public SphereColliderData CalculateSphereDistance(List<Vector3> worldVertices, Transform attachTo)
		{
			return null;
		}

		public SphereColliderData CalculateSphereDistanceLocal(List<Vector3> localVertices)
		{
			return null;
		}

		public SphereColliderData CalculateSphereMinMax(List<Vector3> worldVertices, Transform attachTo)
		{
			return null;
		}

		public SphereColliderData CalculateSphereMinMaxLocal(List<Vector3> localVertices)
		{
			return null;
		}

		private BoxCollider CreateBoxCollider(BoxColliderData data, EasyColliderProperties properties, bool postProcess = true)
		{
			return null;
		}

		public BoxCollider CreateBoxCollider(List<Vector3> vertices, EasyColliderProperties properties, bool isLocal = false)
		{
			return null;
		}

		private CapsuleCollider CreateCapsuleCollider(CapsuleColliderData data, EasyColliderProperties properties, bool postProcess = true)
		{
			return null;
		}

		public CapsuleCollider CreateCapsuleCollider_BestFit(List<Vector3> worldVertices, EasyColliderProperties properties)
		{
			return null;
		}

		public CapsuleCollider CreateCapsuleCollider_MinMax(List<Vector3> worldVertices, EasyColliderProperties properties, CAPSULE_COLLIDER_METHOD method, bool isLocal = false)
		{
			return null;
		}

		public MeshCollider CreateConvexMeshCollider(Mesh mesh, GameObject attachToObject, EasyColliderProperties properties, bool postProcess = true)
		{
			return null;
		}

		private SphereCollider CreateSphereCollider(SphereColliderData data, EasyColliderProperties properties, bool postProcess = true)
		{
			return null;
		}

		public SphereCollider CreateSphereCollider_BestFit(List<Vector3> worldVertices, EasyColliderProperties properties)
		{
			return null;
		}

		public SphereCollider CreateSphereCollider_Distance(List<Vector3> worldVertices, EasyColliderProperties properties)
		{
			return null;
		}

		public SphereCollider CreateSphereCollider_MinMax(List<Vector3> worldVertices, EasyColliderProperties properties, bool isLocal = false)
		{
			return null;
		}

		public void PostColliderCreationProcess(Collider createdCollider, EasyColliderProperties properties)
		{
		}

		public List<Vector3> CalculateCylinderPointsLocal(List<Vector3> vertices, Transform attachTo, int numberOfSides, CYLINDER_ORIENTATION orientation, float cylinderOffset)
		{
			return null;
		}

		private GameObject CreateGameObjectOrientation(List<Vector3> worldVertices, GameObject parent, string name)
		{
			return null;
		}

		private void DebugDrawPoint(Vector3 worldLoc, Color color, float dist = 0.01f)
		{
		}

		private void PostColliderCreation(Collider collider, EasyColliderProperties properties, bool postProcess = true)
		{
		}

		private void SetPropertiesOnCollider(Collider collider, EasyColliderProperties properties)
		{
		}

		private List<Vector3> ToLocalVerts(Transform transform, List<Vector3> worldVertices)
		{
			return null;
		}
	}
}
