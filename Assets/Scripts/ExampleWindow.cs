using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class ExampleWindow : EditorWindow
{
    Color color;

    [MenuItem("Window/Colorizer")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<ExampleWindow>("Colorize");
    }

    private void OnGUI()
    {
        //Window Code
        GUILayout.Label("Color the selected objects!", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color",color);

        if (GUILayout.Button("Colorize"))
        {
            Colorize();
        }
    }
    void Colorize()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                //var tempMaterial = new Material(renderer.sharedMaterial);
                //tempMaterial.color = color;
                //renderer.material = tempMaterial;
                renderer.sharedMaterial.color = color;
            }
        }
    }
}
