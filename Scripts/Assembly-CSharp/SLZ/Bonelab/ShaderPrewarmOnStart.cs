using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

namespace SLZ.Bonelab
{
	public class ShaderPrewarmOnStart : MonoBehaviour
	{
		private class PrewarmObjList
		{
			private int totalCount;

			private List<GameObject> m_gameObjects;

			private List<MeshRenderer> m_meshRenderers;

			private List<MeshFilter> m_meshFilters;

			public int count
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int capacity
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public PrewarmObjList(int capacity_)
			{
			}

			public void Clear()
			{
			}

			public void AddRenderer(Mesh mesh, Material mat)
			{
			}

			public void EnsureCapacity(int newCapacity)
			{
			}

			public void SetCount(int newCount)
			{
			}

			private void CreateMesh(int layer)
			{
			}

			public void Dispose()
			{
			}
		}

		public VtxStructCollection shaderPrewarmQuest;

		public ShaderVariantSet variantCollectionQuest;

		public VtxStructCollection shaderPrewarmPC;

		public ShaderVariantSet variantCollectionPC;

		private VtxStructCollection shaderPrewarm;

		private ShaderVariantSet variantCollection;

		public LoadMenuScene menuLoader;

		public List<Shader> dontUnloadShaders;

		private int shaderCount;

		private int currShaderIdx;

		private int currVariantIdx;

		private int variantCount;

		private int psoCount;

		private List<Mesh> prewarmTris;

		private ushort[] defaultIdxBuffer;

		private byte[] defaultVtxBuffer;

		private GameObject pwCamObj;

		private Camera prewarmCamera;

		private PrewarmObjList prewarmRenderers;

		private HashSet<Shader> dontUnloadSet;

		private static Bounds defaultBounds;

		private SubMeshDescriptor defaultSM;

		private const int prewarmChunkSize = 4;

		private Material[] mats;

		private static readonly ProfilerMarker s_InitShader;

		private static readonly ProfilerMarker s_Prewarm;

		private List<LocalKeyword> localKeywordSpace;

		private Dictionary<int, Mesh> meshLayouts;

		private List<Material> materials;

		private ShaderVariantSet.VariantList varList;

		private int pause;

		private const int pauseTime = 1;

		private int garbageCollection;

		private int garbageCollectionTime;

		[MethodImpl(256)]
		private static void SDebugLog(string s)
		{
		}

		[MethodImpl(256)]
		private static void SDebugLogError(string s)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void PopulateMeshList(VtxStructCollection.ShaderLayout layoutGroup)
		{
		}

		private void DrawTrisForKwSet(Material mat, LocalKeyword[] keywords, int rendererIdx, bool GPUInstanced)
		{
		}

		private void UnloadShaders(int startIdx, int endIdx)
		{
		}
	}
}
