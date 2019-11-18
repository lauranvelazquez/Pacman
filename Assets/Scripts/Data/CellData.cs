using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public enum CellTypes{
kEmpty,
kWall,
kPlayer,
kGhost,
kWarp,
kSpawner,
kPellet,
kNone
}

public abstract class CellData : ScriptableObject
{
   /* public string cellId => $"{cellPosition.x}_{cellPosition.y}";

    //para generar identificadores de celdas
    public CellTypes cellType;

    public Vector2Int cellPosition;
    public CellTypes srcCellTypes;

    public virtual void UpdateCell(CellTypes newType, int newX, int newY)
    {
        cellType = newType;
    }*/
   public Vector2Int logicalPosition;
   public CellTypes srcCellType;
   public bool isWalkable = true;
    
   [NonSerialized] public CellData oldData;
    
    
   [NonSerialized] private CellTypes _cellType;
   public abstract void Load();

}
