using UnityEngine;
using UnityEditor;

public class PopupEdit : EditorWindow
{
    // Add menu item
    [MenuItem("Example/Popup Example")]
    static void Init()
    {
        EditorWindow window = EditorWindow.CreateInstance<PopupEdit>();
        window.Show();
    }

    Rect buttonRect;
    void OnGUI()
    {
        {
            GUILayout.Label("Editor window with Popup example", EditorStyles.boldLabel);
            if (GUILayout.Button("Popup Options", GUILayout.Width(200)))
            {
                PopupWindow.Show(buttonRect, new PopupExample());
            }
            if (Event.current.type == EventType.Repaint) buttonRect = GUILayoutUtility.GetLastRect();
        }
    }
}