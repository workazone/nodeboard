using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NodeBoard
{
    [CreateAssetMenu(fileName = "RangeNodeModel", menuName = "ScriptableObjects/RangeNodeModel", order = 12)]
    public class RangeNodeModel : NodeModel, IRangeNodeModel
    {
        [SerializeField]
        private Sprite _sprite = default;
        [SerializeField]
        private float _from = default;
        [SerializeField]
        private float _to = default;
        [SerializeField]
        private float _initial = default;

        public Sprite Sprite { get { return _sprite; } }
        public float From { get { return _from; } }
        public float To { get { return _to; } }
        public float Initial { get { return _initial; } }
    }
}
