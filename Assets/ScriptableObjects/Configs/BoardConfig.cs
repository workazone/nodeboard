using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NodeBoard
{
    [CreateAssetMenu(fileName = "BoardConfig", menuName = "ScriptableObjects/BoardConfig", order = 0)]
    public class BoardConfig : ScriptableObject
    {
        [Header("Background properties")]
        [SerializeField]
        private Color _backColor = default;
        [SerializeField]
        private Sprite _backSprite = default;
    }
}

