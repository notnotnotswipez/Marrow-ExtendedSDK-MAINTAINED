using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ToolTipManager : MonoBehaviour
	{
		private static ToolTipManager _instance;

		private List<ToolTip> _toolTips;

		private float _maxDistance;

		private float _maxDistanceSqr;

		private float _fovDeg;

		private float _fovDotSin;

		private ToolTip _activeTooltip;

		private static ToolTipManager instance => null;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		public static void RegisterTooltip(ToolTip toolTip)
		{
		}

		public static void UnregisterTooltip(ToolTip toolTip)
		{
		}
	}
}
