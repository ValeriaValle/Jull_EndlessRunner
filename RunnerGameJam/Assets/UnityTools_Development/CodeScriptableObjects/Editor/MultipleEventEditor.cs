using UnityEngine;
using UnityEditor;

namespace UnityTools.Events
{
    [CustomEditor(typeof(GameEventMultiple))]
    public class MultipleEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            GameEventMultiple e = target as GameEventMultiple;
            if (GUILayout.Button("Raise"))
                e.Raise();
        }
    }
}