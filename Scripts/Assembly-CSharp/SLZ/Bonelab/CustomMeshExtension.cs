using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Bonelab
{
	public static class CustomMeshExtension
	{
		private class Vertices
		{
			private List<Vector3> verts;

			private List<Vector2> uv1;

			private List<Vector2> uv2;

			private List<Vector2> uv3;

			private List<Vector2> uv4;

			private List<Vector3> normals;

			private List<Vector4> tangents;

			private List<Color32> colors;

			private List<BoneWeight> boneWeights;

			public Vertices()
			{
			}

			public Vertices(Mesh aMesh)
			{
			}

			private List<T> CreateList<T>(T[] aSource)
			{
				return null;
			}

			private void Copy<T>(ref List<T> aDest, List<T> aSource, int aIndex)
			{
			}

			public int Add(Vertices aOther, int aIndex)
			{
				return 0;
			}

			public void AssignTo(Mesh aTarget)
			{
			}
		}

		public static Mesh GetSubmesh(this Mesh aMesh, int aSubMeshIndex)
		{
			return null;
		}

		public static Mesh SaveMesh(this Mesh mesh, string Path)
		{
			return null;
		}

		public static Mesh ConvertMaterialsToArray(this Mesh SourceMesh)
		{
			return null;
		}

		public static Mesh ConvertMaterialsToArrayInverted(this Mesh SourceMesh)
		{
			return null;
		}

		public static Texture2DArray ConvertToTexture2DArray(this Texture[] textures, TextureFormat textureFormat)
		{
			return null;
		}

		public static Texture2DArray ConvertToTexture2DArray(this Texture[] textures)
		{
			return null;
		}

		public static Texture2DArray SaveAsset(this Texture2DArray texture2DArray, string Path)
		{
			return null;
		}
	}
}
