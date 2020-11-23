using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NodeBoard
{
    public class MainControl : MonoBehaviour
    {
        [SerializeField]
        private BoardConfig _boardConfig = default;
        [SerializeField]
        private SelectorConfig _selectorConfig = default;

        private bool _initialized = false;

        public bool Initialize()
        {
            if (_initialized)
                return true;

            if (!CheckSetupIsValid(out var failedCheck))
            {
                Debug.LogError($"{nameof(MainControl)} failed checking value of: {failedCheck}");
                return false;
            }

            Debug.Log($"{nameof(MainControl)} initialized");

            _initialized = true;

            return true;
        }

        private bool CheckSetupIsValid(out string failed)
        {
            failed = default;

            if (_boardConfig == null)
            {
                failed = nameof(_boardConfig);
                return false;
            }

            if (_selectorConfig == null)
            {
                failed = nameof(_selectorConfig);
                return false;
            }

            return true;
        }
    }
}

