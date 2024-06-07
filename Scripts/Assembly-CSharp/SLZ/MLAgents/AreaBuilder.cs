using UnityEngine;

namespace SLZ.MLAgents
{
	public class AreaBuilder : MonoBehaviour
	{
		public static int nb_rows;

		public static int nb_cols;

		private static int total_cells;

		public int goal_location;

		public int nb_empty_cells;

		public GameObject roadSegment;

		private float road_height;

		private float road_width;

		private int last_row;

		private int last_col;

		private bool row_wall;

		private bool col_wall;

		public GameObject[,] cellList;

		public int[] getRC(int goal)
		{
			return null;
		}

		public void PlaceGoal(int new_loc)
		{
		}

		public void BuildTrack()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
