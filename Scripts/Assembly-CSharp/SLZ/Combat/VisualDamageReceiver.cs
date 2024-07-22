using SLZ.Marrow.Combat;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace SLZ.Combat
{
	public class VisualDamageReceiver : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		[HideInInspector]
		[SerializeField]
		private Vector3 orgpos;

		[SerializeField]
		[HideInInspector]
		private Quaternion orgrot;

		[SerializeField]
		[HideInInspector]
		private Vector3 orgScale;

		public Transform bone;

		[SerializeField]
		[FormerlySerializedAs("ParentObj")]
		private VisualDamageController visualDamageController;

		[SerializeField]
		[Space(5f)]
		[Header("CutOut area")]
		[Space(10f)]
		public GibletEllipsoid[] gibletEllipsoid;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		private int RandomizeGib()
		{
			return 0;
		}

		public void GibletEllipsoidGenerate(int GibletNumber)
		{
		}

		public static Vector3 ExtractTranslationFromMatrix(ref Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		public static Quaternion ExtractRotationFromMatrix(ref Matrix4x4 matrix)
		{
			return default(Quaternion);
		}

		public static Vector3 ExtractScaleFromMatrix(ref Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		public static void DecomposeMatrix(ref Matrix4x4 matrix, out Vector3 localPosition, out Quaternion localRotation, out Vector3 localScale)
		{
			localPosition = default(Vector3);
			localRotation = default(Quaternion);
			localScale = default(Vector3);
		}

		public static void SetTransformFromMatrix(Transform transform, ref Matrix4x4 matrix)
		{
		}
	}
}
