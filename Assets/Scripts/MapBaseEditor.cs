using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapBase))]
public class MapBaseEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        MapBase mapBase = (MapBase)target;

        if (GUILayout.Button("Generate frame"))
        {
            mapBase.FillWithFrame(mapBase.FrameSize);
        }

        if (GUILayout.Button("Generate cube frame"))
        {
            mapBase.CubeFrame(mapBase.FrameSize);
        }

        if (GUILayout.Button("Generate cross"))
        {
            mapBase.Cross(mapBase.FrameSize);
        }
    }
}
