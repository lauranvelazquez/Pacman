using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITriggerable
{
    void Trigger(CellData cell);
    void Trigger<T>(T param);
}
