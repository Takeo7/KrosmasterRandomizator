using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGrid : MonoBehaviour
{
    public GameObject Map;
    public Transform[] Blocks;
    public Transform[,] Grid;

    void Start()
    {
        GetGrid(Map);
    }

    void GetGrid(GameObject Map)
    {
        int length = Map.transform.childCount - 1;
        for (int i = 0; i < length; i++)
        {
            Blocks[i] = Map.transform.GetChild(i);
        }

        Grid = new Transform[6,6];

        int count = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Grid[i, j] = Blocks[count];
                count++;
            }
        }
    }
}
