using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : ExtMonoBehaviour
{
    [SerializeField] protected DamageSender damageSender;
    public DamageSender DamageSender => damageSender;

    [SerializeField] protected DespawnBullet despawnBullet;
    public DespawnBullet DespawnBullet => despawnBullet;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDamageSender();
        this.LoadDespawnBullet();
    }

    private void LoadDespawnBullet()
    {
        if (this.despawnBullet != null) return;
        this.despawnBullet = transform.GetComponentInChildren<DespawnBullet>();
        Debug.Log(transform.name + ": DespawnBullet", gameObject);
    }

    protected virtual void LoadDamageSender()
    {
        if (this.damageSender != null) return;
        this.damageSender = transform.GetComponentInChildren<DamageSender>();
        Debug.Log(transform.name + ": DamageSender", gameObject);
    }
}
