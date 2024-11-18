using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
    private static JunkSpawner instance;
    public static JunkSpawner Instance { get { return instance; } }

    public static string meteoriteOne = "Meteorite_1";
    protected override void Awake()
    {
        base.Awake();
        if (JunkSpawner.instance != null) Debug.LogError("JunkSpawner already exists", gameObject);
        JunkSpawner.instance = this;
    }
}
