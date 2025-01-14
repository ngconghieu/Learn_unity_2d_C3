using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnJunk : DespawnByDistance
{
    public override void DespawnObject()
    {
        JunkSpawner.Instance.Despawn(transform.parent);
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        disLimit = 40f;
    }
}
