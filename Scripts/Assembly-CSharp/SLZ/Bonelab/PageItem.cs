using System;

namespace SLZ.Bonelab
{
	public class PageItem
	{
		public enum Directions
		{
			NORTH = 0,
			NORTHEAST = 1,
			EAST = 2,
			SOUTHEAST = 3,
			SOUTH = 4,
			SOUTHWEST = 5,
			WEST = 6,
			NORTHWEST = 7
		}

		public string name;

		public Directions direction;

		private Action m_Callback;

		public PageItem(string n, Directions d, Action c)
		{
		}

		public void Invoke()
		{
		}
	}
}
