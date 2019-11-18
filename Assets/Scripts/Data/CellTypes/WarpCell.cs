using UnityEngine;

public class WarpCell  : CellData, ITriggerable {
    [SerializeField] private Transform _destination;
    public WarpCell destinationCell;
    
    public override void Load() {
        
    }

    public void Trigger(CellData cell)
    {
        throw new System.NotImplementedException();
    }

    public void Trigger<T>(T param) {
        var agent = param as IWarpable;
        agent?.WarpTo(_destination.position);
    }
}