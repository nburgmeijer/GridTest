using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    private int _width;
    private int _height;
    private int _size;
    private int[,] _gridArray;
    private Material material;

    public Grid(int width, int height, int size, Material material)
    {
        _width = width;
        _height = height;
        _size = size;
        _gridArray = new int[width, height];
        this.material = material;
    
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            { 
                Debug.DrawLine(new Vector3(x, y), new Vector3(x, y + 1), Color.white, 100f);
                Debug.DrawLine(new Vector3(x, y), new Vector3(x + 1, y), Color.white, 100f);
            }
        }
        CodeMonkey.Utils.World_Mesh.UVCoords uVCoords = new CodeMonkey.Utils.World_Mesh.UVCoords(0, 0, 1, 1);
        CodeMonkey.Utils.World_Mesh.Create(new Vector3(1, 1, 0), new Vector3(2, 2, 0), material, uVCoords);
        
        Debug.DrawLine(new Vector3(0, height), new Vector3(width, height), Color.white, 100f);
        Debug.DrawLine(new Vector3(width, 0), new Vector3(width, height), Color.white, 100f);
    }
    
}

