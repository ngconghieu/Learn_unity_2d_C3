using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentFly : ExtMonoBehaviour
{
    [SerializeField] protected float moveSpeed = 10;
    [SerializeField] protected Vector3 direction = Vector3.right;

    protected virtual void Update()
    {
        transform.parent.Translate(this.moveSpeed * Time.deltaTime * this.direction);
    }
}
