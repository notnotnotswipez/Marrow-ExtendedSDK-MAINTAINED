using System.Collections.Generic;

namespace SLZ.Marrow
{
	public class TagTree
	{
		private TagTreeNode _rootNode;

		private TagTreeNode _currentNode;

		private List<TagTreeNode> _allTagsInTree;

		public TagTreeNode RootNode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TagTreeNode CurrentNode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<TagTreeNode> AllTagsInTree
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TagTree(bool autoSetup = true)
		{
		}

		private void SetupTagTree()
		{
		}

		public List<TagTreeNode> GetAllTags()
		{
			return null;
		}

		public void FindTagsInChildren(TagTreeNode currentNode, List<TagTreeNode> foundTags)
		{
		}
	}
}
