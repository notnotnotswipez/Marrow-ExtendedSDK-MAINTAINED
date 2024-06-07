using System.Collections.Generic;

namespace SLZ.Marrow
{
	public class TagTreeNode
	{
		private string _tagName;

		private TagTreeNode _parent;

		private List<TagTreeNode> _tagChildren;

		private List<string> _tagChildrenStrings;

		private List<TagTreeNode> _tagPath;

		public string TagName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TagTreeNode Parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<TagTreeNode> TagChildren
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> TagChildrenStrings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<TagTreeNode> TagPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TagTreeNode(string tagName, params TagTreeNode[] tagChildren)
		{
		}

		public void AddChild(params TagTreeNode[] newChildren)
		{
		}

		public TagTreeNode GetNode(string tagName)
		{
			return null;
		}

		public bool HasChildren()
		{
			return false;
		}

		public bool HasParent()
		{
			return false;
		}

		private void BuildTagTreePath(TagTreeNode currentNode)
		{
		}
	}
}
