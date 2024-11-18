using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnBullet : DespawnByDistance
{
    public override void DespawnObject()
    {
        BulletSpawner.Instance.Despawn(transform.parent);
    }
}
