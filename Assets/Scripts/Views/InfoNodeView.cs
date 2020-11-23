using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace NodeBoard
{
    public class InfoNodeView : NodeView<IInfoNodeModel>
    {
        [SerializeField]
        private TextMeshProUGUI _description = default;
        [SerializeField]
        private Image _image = default;

        public override void Initialize(IInfoNodeModel viewModel)
        {
            base.Initialize(viewModel);

            _description.text = _data.Description;
            _image.color = _data.Color;

            _initialized = true;
        }

        protected override bool CheckIsValid(out string failed)
        {
            if (_description == null)
            {
                failed = nameof(_description);
                return false;
            }

            if (_image == null)
            {
                failed = nameof(_image);
                return false;
            }

            return base.CheckIsValid(out failed);
        }
    }
}

