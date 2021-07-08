using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EasyLevelSelector))]
public class LevelSelectorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EasyLevelSelector script = (EasyLevelSelector)target;

        GUIContent arrayLabel = new GUIContent("MyArray");
        script.arrayIDX = EditorGUILayout.Popup(arrayLabel, script.arrayIDX, script.myArray);
    }
}
