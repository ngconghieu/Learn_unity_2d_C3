using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{
    private static BulletSpawner instance;
    public static BulletSpawner Instance { get { return instance; } }

    public static string bulletOne = "Bullet_1";
    protected override void Awake()
    {
        base.Awake();
        if(BulletSpawner.instance != null) Debug.LogError("BulletSpawner already exists", gameObject);
        BulletSpawner.instance = this;
    }
}
