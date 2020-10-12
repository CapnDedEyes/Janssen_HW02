using UnityEngine;
using UnityEditor;
using System;

[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Cube cube = (Cube)target;

        GUILayout.BeginHorizontal();

            if(GUILayout.Button("Boosh"))
            {
                cube?.Boosh();
            }

            if (GUILayout.Button("Quack"))
            {
                cube?.Quack();
            }

        GUILayout.EndHorizontal();
        
        //GUILayout.Label("Resize");

            //cube.baseSize = EditorGUILayout.Slider("Size",cube.baseSize, 0.1f, 2f);

            //cube.transform.localScale = Vector3.one * cube.baseSize;
    }
}
