using TMPro.EditorUtilities;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

[CreateAssetMenu (fileName = "New Unit Data", menuName = "Roguelike/unit Data")]
public class UnitData : ScriptableObject
{
    [Header("Visuals")]
    public Sprite unitSprite;
    public string unitName;

    [Header("Gameplay Stats")]
    public int health;
    public int attack;
    public int defense;

    [Header("Placemat")]
    public int baseSize = 1;
}
