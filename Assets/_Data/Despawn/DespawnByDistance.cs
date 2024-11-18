using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField] protected float disLimit = 20f;
    [SerializeField] protected float distance = 0;
    [SerializeField] protected Transform mainCam;

    protected override void LoadComponents()
    {
        this.LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if(this.mainCam != null) return;
        this.mainCam = Transform.FindObjectOfType<Camera>().transform;
        Debug.Log(transform.parent.name + ": Load Camera", gameObject);
    }

    protected override bool CanDespawn()
    {
        distance = Vector3.Distance(transform.position, mainCam.position);
        return distance > disLimit;
    }
}
