using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    [SerializeField]
    private int _x;
    [SerializeField]
    private int _y;
    [SerializeField]
    private int _size;

    private int[,] _gridArray;

    public Grid(int x, int y, int size)
    {
        _x = x;
        _y = y;
        _size = size;
        _gridArray = new int[x, y];

    }
}

