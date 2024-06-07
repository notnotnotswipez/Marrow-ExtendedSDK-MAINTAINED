using System.Collections.Generic;
using PathCreation;
using PathCreation.Examples;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class TrackUtils : MonoBehaviour
	{
		private List<GameObject> debugObjArr;

		public int WrapAroundInd(int ind, int len)
		{
			return 0;
		}

		public void PlaceCheckpoints(TrackClass trackClass)
		{
		}

		public void DestroyCheckpoints(TrackClass trackClass)
		{
		}

		public void PlaceCheckpoints(TrackClass trackClass, VertexPath partitionVp, GameObject parent, int nbCheckpoints, int partInd = 0, float lastPartLength = 0f)
		{
		}

		public void RemoveAllCps(ref GameObject[] checkpointArray)
		{
		}

		public void ReverseCpArr(TrackClass trackClass, bool usePartition = false)
		{
		}

		public (int, float, Vector3) PartPointBetweenCheckpoints(TrackClass trackClass, GameObject cur_zone, GameObject next_zone, List<RoadMeshCreator_Custom> rmcs, bool rndmPoint = false)
		{
			return default((int, float, Vector3));
		}

		public void ObsSpawner(TrackClass trackClass, GameObject cur_zone, GameObject next_zone, List<RoadMeshCreator_Custom> rmcs, float weight = 1f)
		{
		}

		public void PlaceObstacles(TrackClass trackClass, GameObject spawnArea, float nb_zones, float nb_obs, List<RoadMeshCreator_Custom> rmcs)
		{
		}

		public void RescaleObstacle(TrackClass trackClass, ref GameObject obsObj)
		{
		}

		public void PlaceWalls(TrackClass trackClass)
		{
		}

		public void BuildJumps(TrackClass trackClass)
		{
		}

		public void AddNavSurface(TrackClass trackClass)
		{
		}

		public Vector3 GetVPBetweenCheckpoints(TrackClass trackClass, Vector3 first_pos, Vector3 second_pos)
		{
			return default(Vector3);
		}

		public Vector3 GetRotBetweenCheckpoints(TrackClass trackClass, Vector3 pos, GameObject first)
		{
			return default(Vector3);
		}

		public void DestroyArrObjs(GameObject[] arr)
		{
		}

		public void DestroyArrListObjs(List<GameObject> arr)
		{
		}

		public void DisplayVecArr(Vector3[] arr, GameObject vertPrefab, bool destroy = true, bool partitionMat = false)
		{
		}

		public void DisplayVecArr(VertexPath vp, GameObject vertPrefab, bool destroy = true, bool partitionMat = false)
		{
		}
	}
}
