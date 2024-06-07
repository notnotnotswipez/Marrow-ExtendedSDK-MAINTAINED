using UnityEditor;
using UnityEngine;
using System;
#if UNITY_2020_2_OR_NEWER
using UnityEditor.AssetImporters;
using UnityEditor.Experimental.AssetImporters;
#else
using UnityEditor.Experimental.AssetImporters;
#endif
using System.Reflection;

namespace Unity.Sentis.Editor
{
[CustomEditor(typeof(ONNXModelImporter))]
[CanEditMultipleObjects]
class ONNXModelImporterEditor : ScriptedImporterEditor
{
    static PropertyInfo s_InspectorModeInfo;

    static ONNXModelImporterEditor()
    {
        s_InspectorModeInfo = typeof(SerializedObject).GetProperty("inspectorMode", BindingFlags.NonPublic | BindingFlags.Instance);
    }

    public override void OnInspectorGUI()
    {
        var onnxModelImporter = target as ONNXModelImporter;
        if (onnxModelImporter == null)
        {
            ApplyRevertGUI();
            return;
        }

        InspectorMode inspectorMode = InspectorMode.Normal;
        if (s_InspectorModeInfo != null)
            inspectorMode = (InspectorMode)s_InspectorModeInfo.GetValue(assetSerializedObject);

        serializedObject.Update();

        bool debugView = inspectorMode != InspectorMode.Normal;
        SerializedProperty iterator = serializedObject.GetIterator();
        for (bool enterChildren = true; iterator.NextVisible(enterChildren); enterChildren = false)
        {
            if (iterator.propertyPath != "m_Script")
                EditorGUILayout.PropertyField(iterator, true);
        }

        if (onnxModelImporter.optimizeModel)
        {
            EditorGUILayout.HelpBox("Model optimizations are on\nRemove and re-import model if you observe incorrect behavior", MessageType.Info);
        }

        serializedObject.ApplyModifiedProperties();

        ApplyRevertGUI();
    }
}
}
