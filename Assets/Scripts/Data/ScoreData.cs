using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreData : ScriptableObject
{
    //Source Static Data
    //se puede convertir jason-> string-> codeable
    [SerializeField]public int baseScore = 10;
    
    //Dynamic Data
    [NonSerialized] private int score;
    
    public void UpdateScore(int multiplayer)
    {
        score = baseScore * multiplayer;
    }
}

//scriptable objects en build no guarda datos
//se crea una estructura genema que guarda datos

[System.Serializable]
public class SerializableScoreData
{
    private int score;
    //TERMINAR LA ESTRUCTURA 
    //SOLO CODIGO
    //RESOLVER GHOST 
}
