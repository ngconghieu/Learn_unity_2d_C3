using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public abstract class DamageReceiver : ExtMonoBehaviour
{
    [Header("Damage Receiver")]
    [SerializeField] protected SphereCollider sphereCollider;
    [SerializeField] protected bool isDead = false;
    [SerializeField] protected int hp = 1;
    [SerializeField] protected int hpMax = 2;

    protected override void OnEnable()
    {
        this.Reborn();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCollider();
    }

    protected virtual void LoadCollider()
    {
        if (sphereCollider != null) return;
        this.sphereCollider = GetComponent<SphereCollider>();
        sphereCollider.isTrigger = true;
        sphereCollider.radius = 0.6f;
        Debug.Log(transform.name + ": LoadCollider", gameObject);
    }

    protected virtual void Reborn()
    {
        this.hp = this.hpMax;
        this.isDead = false;
    }

    public virtual void Add(int add)
    {
        if (isDead) return;
        this.hp += add;
        if (hp > hpMax) hp = hpMax;
    }

    public virtual void Deduct(int deduct)
    {
        if (isDead) return;
        hp -= deduct;
        if (hp < 0) hp = 0;
        this.CheckIsDead();
    }

    protected virtual void CheckIsDead()
    {
        if (!IsDead()) return;
        isDead = true;
        OnDead();
    }

    protected abstract void OnDead();

    protected virtual bool IsDead()
    {
        return hp <= 0;
    }
}
