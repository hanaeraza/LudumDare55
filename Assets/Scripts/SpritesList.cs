using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Sprites List")]
public class SpritesList : ScriptableObject
{
    [SerializeField]
    public Sprite[] sprites;
}
