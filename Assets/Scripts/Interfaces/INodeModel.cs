using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NodeBoard
{
    public interface INodeModel
    {
        string Id { get; }
        NodeType Type { get; }
        string Title { get; }
    }
}
