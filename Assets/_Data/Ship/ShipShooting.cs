using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected bool isShooting = false;
    [SerializeField] protected float shootDelay = 0.1f;
    [SerializeField] protected float shootTimer = 0f;

    protected virtual void Update()
    {
        this.IsShooting();
    }

    protected virtual void FixedUpdate()
    {
        this.Shooting();
    }

    protected virtual void Shooting()
    {
        if (!isShooting) return;

        this.shootTimer += Time.fixedDeltaTime;
        if (this.shootTimer < this.shootDelay) return;
        this.shootTimer = 0;

        Vector3 spawnPos = transform.parent.position;
        Quaternion rotation = transform.parent.rotation;
        Transform newBullet = BulletSpawner.Instance.Spawn(BulletSpawner.bulletOne, spawnPos, rotation);
        if(newBullet == null) return;
        newBullet.gameObject.SetActive(true);
        Debug.Log("Shooting");
    }

    protected virtual void IsShooting()
    {
        this.isShooting = InputManager.Instance.MouseDown > 0;
    }
}
