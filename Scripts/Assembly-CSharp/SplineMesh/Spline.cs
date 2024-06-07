using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SplineMesh
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class Spline : MonoBehaviour
	{
		public List<SplineNode> nodes;

		[HideInInspector]
		public List<CubicBezierCurve> curves;

		public float Length;

		[SerializeField]
		private bool isLoop;

		[HideInInspector]
		public UnityEvent CurveChanged;

		private SplineNode start;

		private SplineNode end;

		public bool IsLoop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event ListChangeHandler<SplineNode> NodeListChanged
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

		private void Reset()
		{
		}

		private void OnEnable()
		{
		}

		public ReadOnlyCollection<CubicBezierCurve> GetCurves()
		{
			return null;
		}

		private void RaiseNodeListChanged(ListChangedEventArgs<SplineNode> args)
		{
		}

		private void UpdateAfterCurveChanged()
		{
		}

		public CurveSample GetSample(float t)
		{
			return default(CurveSample);
		}

		public CubicBezierCurve GetCurve(float t)
		{
			return null;
		}

		private int GetNodeIndexForTime(float t)
		{
			return 0;
		}

		public void RefreshCurves()
		{
		}

		public CurveSample GetSampleAtDistance(float d)
		{
			return default(CurveSample);
		}

		public void AddNode(SplineNode node)
		{
		}

		public void InsertNode(int index, SplineNode node)
		{
		}

		public void RemoveNode(SplineNode node)
		{
		}

		private void updateLoopBinding()
		{
		}

		private void StartNodeChanged(object sender, EventArgs e)
		{
		}

		private void EndNodeChanged(object sender, EventArgs e)
		{
		}

		public CurveSample GetProjectionSample(Vector3 pointToProject)
		{
			return default(CurveSample);
		}
	}
}
