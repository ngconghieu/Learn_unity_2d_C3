using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : ExtMonoBehaviour
{
    [SerializeField] protected Transform model;
    public Transform Model { get => model; }

    [SerializeField] protected DespawnJunk despawnJunk;
    public DespawnJunk DespawnJunk => despawnJunk;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
        this.LoadDespawnJunk();
    }

    protected virtual void LoadDespawnJunk()
    {
        if (this.despawnJunk != null) return;
        this.despawnJunk = transform.GetComponentInChildren<DespawnJunk>();
        Debug.Log(transform.name + ": LoadDespawnJunk", gameObject);
    }

    protected virtual void LoadModel()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
        Debug.Log(transform.name + ": LoadModel", gameObject);
    }
}
