using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public static class Constants
	{
		public const string EXTENSION_PREFAB = "prefab";

		public const string LABEL_IVY_PRESET = "IvyPreset";

		public const int VERTEX_LIMIT_16 = 65535;

		public const int VERTEX_LIMIT_32 = 4000000;

		public const string IVY_MESH_NAME = "IvyMesh";

		public const string NO_IVY_SELECTED_MESSAGE = "Select or create an editable ivy first.";

		public const string CANNOT_EDIT_GROWING_IVY = "Can't edit a growing ivy.";

		public const string CONFIRM_SAVE_IVY = "Saving the ivy means that editability will be lost. Are you sure?";

		public const string LIGHTMAP_UVS_WARNING = "Lightmap UVs will be generated when you save the ivy either in a scene or as prefab.";

		public static GUIContent TOOL_PAINT_GUICONTENT;

		public static GUIContent TOOL_MOVE_GUICONTENT;

		public static GUIContent TOOL_SMOOTH_GUICONTENT;

		public static GUIContent TOOL_REFINE_GUICONTENT;

		public static GUIContent TOOL_OPTIMIZE_GUICONTENT;

		public static GUIContent TOOL_CUT_GUICONTENT;

		public static GUIContent TOOL_DELETE_GUICONTENT;

		public static GUIContent TOOL_SHAVE_GUICONTENT;

		public static GUIContent TOOL_ADDLEAVE_GUICONTENT;

		public static GUIContent TOOL_TOGGLEPANEL_GUICONTENT;
	}
}
