using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NodeBoard
{
    public class NodeModel : ScriptableObject, INodeModel
    {
        private string _id = default;

        [SerializeField]
        private NodeType _type = default;
        [SerializeField]
        private string _title = default;

        public string Id { get { return _id; } }
        public NodeType Type { get { return _type; } }
        public string Title { get { return _title; } }        
    }
}