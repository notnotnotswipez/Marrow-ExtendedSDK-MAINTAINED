using UnityEngine;

namespace SLZ.VFX
{
	public class ScopeManager : MonoBehaviour
	{
		[SerializeField]
		private Camera ScopeCamera;

		[SerializeField]
		private Renderer ScopeRenderer;

		private RenderTexture camRT;

		[SerializeField]
		[Range(0f, 10f)]
		public int frameskip;

		[SerializeField]
		[Range(0f, 1028f)]
		private int RenderTextureRes;

		private Material ScopeMat;

		private int DeltaID;

		private int framecounter;

		private Quaternion rotationHistory;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void RenderScope()
		{
		}

		private void OnDisable()
		{
		}
	}
}
