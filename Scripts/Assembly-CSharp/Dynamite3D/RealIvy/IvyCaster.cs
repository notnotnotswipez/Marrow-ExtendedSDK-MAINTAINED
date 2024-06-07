using System.Collections.Generic;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class IvyCaster : MonoBehaviour
	{
		public IvyPreset[] ivyPresets;

		public List<IvyController> ivys;

		public IvyController prefabIvyController;

		public void CastIvyByPresetName(string presetName, Vector3 position, Quaternion rotation)
		{
		}

		public void CastIvy(IvyPreset ivyPreset, Vector3 position, Quaternion rotation)
		{
		}

		public void CastRandomIvy(Vector3 position, Quaternion rotation)
		{
		}

		private IvyController GetFreeIvy()
		{
			return null;
		}

		private IvyPreset GetPresetByName(string presetName)
		{
			return null;
		}
	}
}
