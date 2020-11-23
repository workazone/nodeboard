using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NodeBoard
{
    public interface IRangeNodeModel : INodeModel
    {
        Sprite Sprite { get; }
        float From { get; }
        float To { get; }
        float Initial { get; }
    }
}
