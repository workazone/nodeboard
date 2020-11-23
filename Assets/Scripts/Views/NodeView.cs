using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NodeBoard
{
    public class NodeView<T> : MonoBehaviour where T : INodeModel
    {
        [SerializeField]
        private Button _closeButton = default;

        protected bool _initialized = false;
        protected T _data;

        public virtual void Initialize(T data)
        {
            if (_initialized)
                return;

            _data = data;

            if (!CheckIsValid(out var failedCheck))
            {
                Debug.LogError($"{nameof(NodeView<T>)} failed checking value of: {failedCheck}");
                return;
            }

            _closeButton.onClick.AddListener(OnCloseButtonClicked);           
        }

        public void OnCloseButtonClicked()
        {
            Destroy(this.gameObject);
        }

        protected virtual bool CheckIsValid(out string failed)
        {
            failed = default;

            if (_data == null)
            {
                failed = nameof(_data);
                return false;
            }

            if (_closeButton == null)
            {
                failed = nameof(_closeButton);
                return false;
            }

            return true;
        }
    }
}

