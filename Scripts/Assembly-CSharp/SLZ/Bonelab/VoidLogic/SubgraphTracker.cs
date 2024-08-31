using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	public class SubgraphTracker : MonoBehaviour
	{
		public VoidLogicToolSettings ToolSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public VoidLogicSubgraph Subgraph
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool Deprecated
		{
			get
			{
				return default(bool);
			}
		}

		public GameObject LineRenderersGO
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public GameObject IconRenderersGO
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void DisplaySubgraph()
		{
		}

		private void HideSubgraph()
		{
		}

		public SubgraphTracker()
		{
		}

		[HideInInspector]
		[SerializeField]
		private bool _deprecated;

		private bool _wasEnabled;

		private Mesh _quadMesh;

		private Dictionary<ValueTuple<IVoidLogicSource, IVoidLogicSink>, LineRenderer> _lineRenderers;

		private Dictionary<IVoidLogicNode, ValueTuple<GameObject, MaterialPropertyBlock>> _icons;
	}
}
