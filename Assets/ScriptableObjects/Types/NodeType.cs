using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NodeBoard
{
    [CreateAssetMenu(fileName = "NodeType", menuName = "ScriptableObjects/NodeType", order = 10)]
    public class NodeType : ScriptableObject
    {
        [SerializeField]
        private GameObject _prefab = default;
    }
}