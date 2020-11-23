using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace NodeBoard
{
    [Serializable]
    public class NodeVariant
    {
        public NodeModel Model;
        public NodeType Type;
    }

    [CreateAssetMenu(fileName = "SelectorConfig", menuName = "ScriptableObjects/SelectorConfig", order = 1)]
    public class SelectorConfig : ScriptableObject
    {
        [SerializeField]
        private NodeVariant[] _nodeVariants = default;

        public NodeVariant[] NodeVariants { get { return _nodeVariants; } }
    }
}