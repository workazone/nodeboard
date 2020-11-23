using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace NodeBoard
{
    public class RangeNodeView : NodeView<IRangeNodeModel>
    {
        [SerializeField]
        private Slider _slider = default;
        [SerializeField]
        private Image _image = default;

        private RectTransform _targetRTrans = default;
        private float _from = default;
        private float _to = default;
        private float _initial = default;

        public override void Initialize(IRangeNodeModel viewModel)
        {
            base.Initialize(viewModel);

            _from = _data.From;
            _to = _data.To;
            _initial = _data.Initial;
            
            _targetRTrans = _image.GetComponent<RectTransform>();
            SetupTarget(_targetRTrans, _data.Initial);

            _initialized = true;
        }

        protected override bool CheckIsValid(out string failed)
        {
            if (_slider == null)
            {
                failed = nameof(_slider);
                return false;
            }

            if (_image == null)
            {
                failed = nameof(_image);
                return false;
            }

            return base.CheckIsValid(out failed);
        }

        private void SetupTarget(RectTransform rtrans, float initialAngle)
        {
            var rotation = rtrans.localRotation;
            rotation.z = -initialAngle * 360f;
            rtrans.localRotation = rotation;
        }
    }
}
