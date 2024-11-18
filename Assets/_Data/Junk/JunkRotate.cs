using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRotate : JunkAbstract
{
    [SerializeField] protected float speed = 50f;

    protected virtual void FixedUpdate()
    {
        this.Rotating();
    }

    protected virtual void Rotating()
    {
        if (this.junkCtrl == null || this.junkCtrl.Model == null) return;

        Vector3 eulers = new(0, 0, 1);
        Transform model = this.junkCtrl.Model;
        model.Rotate(speed * Time.fixedDeltaTime * eulers);
    }
}