using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentGrid : MonoBehaviour
{
    [SerializeField]
    private Material material;
    private Grid _grid;
    // Start is called before the first frame update
    void Start()
    {
        _grid = new Grid(2, 4, 16,material);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
