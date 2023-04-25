
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[CustomEditor(typeof(GridManager))]
public class GUIManager : Editor
{
    public override void OnInspectorGUI()
    { 
        DrawDefaultInspector(); 
        GridManager gridManager = (GridManager)target;

        if (GUILayout.Button("Create Tiles", GUILayout.Width(200), GUILayout.Height(50)))
        {
            gridManager.CreateTiles(); 
        }   
    }
}