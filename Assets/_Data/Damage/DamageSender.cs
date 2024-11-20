using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : ExtMonoBehaviour
{
    [SerializeField] protected int damage = 1;

    public virtual void Send(Transform obj)
    {
        DamageReceiver damageReceiver;
        damageReceiver = obj.GetComponentInChildren<DamageReceiver>();
        if (damageReceiver == null) return;
        this.Send(damageReceiver);
        this.CreateFXImpact();
    }

    public virtual void Send(DamageReceiver damageReceiver)
    {
        damageReceiver.Deduct(this.damage);
    }

    protected virtual void CreateFXImpact()
    {
        string fxName = this.GetImpactFXName();
        Vector3 hitPos = transform.position;
        Quaternion hitRot = transform.rotation * Quaternion.Euler(0f, 0f, 90f);

        Transform fxImpact = FXSpawner.Instance.Spawn(fxName, hitPos, hitRot);
        fxImpact.gameObject.SetActive(true);
    }

    protected virtual string GetImpactFXName()
    {
        return FXSpawner.impact1;
    }

}
