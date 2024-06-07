using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PathCreation.Examples
{
	[ExecuteInEditMode]
	public abstract class PathSceneTool : MonoBehaviour
	{
		public PathCreator pathCreator;

		public bool autoUpdate;

		private VertexPath storedPath;

		public VertexPath StoredPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected VertexPath path => null;

		public event Action onDestroyed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void TriggerUpdate()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected abstract void PathUpdated();
	}
}
