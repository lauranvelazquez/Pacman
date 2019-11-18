using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//tiene que tener un gameobject
public class GridController: MonoBehaviour
{
    [SerializeField] private GridData _gridData;

    private void Start()
    {
        _gridData.Load();
    }

    void UpdateGridState()
    {
        
    }

    public CellData GetCell(Vector2Int cellPosition)
    {
        return _gridData.GridStates.Find(cell=> String.Compare())
    }
}