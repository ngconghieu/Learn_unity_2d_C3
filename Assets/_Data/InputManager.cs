using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //singleton
    private static InputManager instance;
    public static InputManager Instance { get => instance; }

    [SerializeField] protected Vector3 mouseWorldPos;
    public Vector3 MouseWorldPos { get { return mouseWorldPos; } }

    [SerializeField] protected float mouseDown;
    public float MouseDown { get { return mouseDown; } }

    protected virtual void Awake()
    {
        if (InputManager.instance != null) Debug.LogError("Only 1 InputManager allow to exist");
        InputManager.instance = this;
    }
    protected virtual void FixedUpdate()
    {
        this.GetMousePos();
    }
    protected virtual void Update()
    {
        this.GetMouseDown();
    }

    protected virtual void GetMouseDown()
    {
        //this.mouseDown = Input.GetMouseButton(0) ? 1 : 0;
        this.mouseDown = Input.GetAxis("Fire1");
    }

    protected virtual void GetMousePos()
    {
        this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
