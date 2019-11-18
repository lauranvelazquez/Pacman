using System;
using System.Collections;
using System.Collections.Generic;
using Events;
using UnityEngine;

public class PelletCell : CellData, ITriggerable
{
    [SerializeField] private bool _isBig;
    [SerializeField] private int _scoreMultiplier = 1;
    //Template para pasar cualquier tipo de parametro al metodo
    //Es como un comodin, para asignar cualquier elemento
    //T es un parametro generico
    [NonSerialized] public BigPelletEvent _BigPelletEvent;
    public void Trigger(CellData cell)
    {
        
    }

    public void Trigger<T>(T param)
    {
        //casteos estaticos y dinamicos para cambiar tipos de datos
        //estaticos cuando estoy segura de que va a ser ese tipo de dato
        //si no es lo que dije se guarda como null
        PlayerCell player= param as PlayerCell;
        if (_isBig)
        {
            //player do something
            //afecta a los fantasmas 
            EventController.TriggerEvent(_bigPelletEvent);
        }
        else
        {
            //agrega score al player
            player.UpdateScore(_scoreMultiplier);
        }
        
    }
    
    
}
