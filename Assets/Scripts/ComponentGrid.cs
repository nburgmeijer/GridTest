using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentGrid : MonoBehaviour
{
    private Grid _grid;
    // Start is called before the first frame update
    void Start()
    {
        _grid = new Grid(10, 10, 16);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
