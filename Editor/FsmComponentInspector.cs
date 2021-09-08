using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GF.Fsm.Editor
{
    [CustomEditor(typeof(FsmComponent))]
    public class FsmComponentInspector : UnityEditor.Editor
    {

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (!EditorApplication.isPlaying)
            {
                EditorGUILayout.HelpBox("Available during runtime only.", MessageType.Info);
                return;
            }

            FsmComponent t = (FsmComponent)target;

            if (IsPrefabInHierarchy(t.gameObject))
            {
                EditorGUILayout.LabelField("FSM Count", t.Count.ToString());

                FsmBase[] fsms = t.GetAllFsms();
                foreach (FsmBase fsm in fsms)
                {
                    DrawFsm(fsm);
                }
            }

            Repaint();
        }

        private bool IsPrefabInHierarchy(UnityEngine.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

#if UNITY_2018_3_OR_NEWER
            return PrefabUtility.GetPrefabAssetType(obj) != PrefabAssetType.Regular;
#else
            return PrefabUtility.GetPrefabType(obj) != PrefabType.Prefab;
#endif
        }

        private void DrawFsm(FsmBase fsm)
        {
            EditorGUILayout.LabelField(fsm.FullName, fsm.IsRunning ? Utility.Text.Format("{0}, {1:F1} s", fsm.CurrentStateName, fsm.CurrentStateTime) : (fsm.IsDestroyed ? "Destroyed" : "Not Running"));
        }

    }
}

