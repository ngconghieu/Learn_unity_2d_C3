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

    [SerializeField] protected JunkSO junkSO;
    public JunkSO JunkSO => junkSO;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
        this.LoadDespawnJunk();
        this.LoadJunkSO();
    }

    protected virtual void LoadJunkSO()
    {
        if (this.junkSO != null) return;
        string resPath = "Junk/" + transform.name;
        this.junkSO = Resources.Load<JunkSO>(resPath);
        Debug.Log(transform.name + ": LoadJunkSO"+ resPath, gameObject);
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
