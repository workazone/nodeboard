using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NodeBoard
{
    public class RootInitializer : ScriptableObject
    {
        static private bool _initialized = false;

        [RuntimeInitializeOnLoadMethod()]
        public static void Default()
        {
            if (_initialized)
                return;

            InitializeSystem();

            _initialized = true;
        }

        static private void InitializeSystem()
        {
            var mainPrefab = Instantiate(Resources.Load("Main")) as GameObject;
            var mainControl = mainPrefab.GetComponent<MainControl>();

            if (!mainControl.Initialize())
                Debug.LogError("Main control failed to initialize.");
        }
    }
}
