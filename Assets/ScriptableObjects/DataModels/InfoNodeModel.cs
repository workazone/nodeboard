using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NodeBoard
{
    [CreateAssetMenu(fileName = "InfoNodeModel", menuName = "ScriptableObjects/InfoNodeModel", order = 11)]
    public class InfoNodeModel : NodeModel, IInfoNodeModel
    {
        [SerializeField]
        private Color _color = default;
        [SerializeField]
        private string _description = default;

        public Color Color { get { return _color; } }
        public string Description { get { return _description; } }
    }
}

