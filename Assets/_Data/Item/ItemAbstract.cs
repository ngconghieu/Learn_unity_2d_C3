using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemAbstract : ExtMonoBehaviour
{
    [SerializeField] protected ItemCtrl itemCtrl;
    public ItemCtrl ItemCtrl { get => itemCtrl; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkCtrl();
    }

    protected virtual void LoadJunkCtrl()
    {
        if (this.itemCtrl != null) return;
        this.itemCtrl = transform.parent.GetComponent<ItemCtrl>();
        Debug.Log(transform.name + ": LoadJunkCtrl", gameObject);
    }
}
