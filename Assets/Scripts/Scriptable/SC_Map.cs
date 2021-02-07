using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Map_", menuName = "New Map")]
public class SC_Map : ScriptableObject
{
    public string _name;
    public Sprite map_Image;
    public Vector2[] monster_spawns;
    public Vector2[] tree_spawns;
    public Vector2[] mineral_spawn;
    public Vector2[] special_spawn;
    public Vector2[] dropable_spawn;
}
