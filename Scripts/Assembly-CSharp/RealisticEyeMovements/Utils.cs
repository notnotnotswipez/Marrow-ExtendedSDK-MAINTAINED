using System.Collections.Generic;
using UnityEngine;

namespace RealisticEyeMovements
{
	public class Utils
	{
		private static readonly Dictionary<string, GameObject> dummyObjects;

		public static bool CanGetTransformFromPath(Transform startXform, string path)
		{
			return false;
		}

		public static float EaseSineIn(float t, float b, float c, float d)
		{
			return 0f;
		}

		public static float Fbm(Vector2 coord, int octave)
		{
			return 0f;
		}

		public static GameObject FindChildInHierarchy(GameObject go, string name)
		{
			return null;
		}

		public static Transform GetCommonAncestor(Transform xform1, Transform xform2)
		{
			return null;
		}

		public static string GetPathForTransform(Transform startXform, Transform targetXform)
		{
			return null;
		}

		public static Transform GetTransformFromPath(Transform startXform, string path)
		{
			return null;
		}

		public static bool IsEqualOrDescendant(Transform ancestor, Transform descendant)
		{
			return false;
		}

		public static float NormalizedDegAngle(float degrees)
		{
			return 0f;
		}

		public static void PlaceDummyObject(string name, Vector3 pos, float scale = 0.1f, Quaternion? rotation = null)
		{
		}
	}
}
