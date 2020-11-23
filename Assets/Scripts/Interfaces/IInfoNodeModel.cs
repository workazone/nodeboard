using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NodeBoard
{
    public interface IInfoNodeModel : INodeModel
    {
        string Description { get; }
        Color Color { get; }
    }
}
