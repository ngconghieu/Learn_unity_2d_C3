using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkFly : ParentFly
{
    [SerializeField] protected float minCamPos = -16;
    [SerializeField] protected float maxCamPos = 16;

    protected override void ResetValue()
    {
        base.ResetValue();
        this.moveSpeed = 1;
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        this.GetFlyDirection();
    }

    protected virtual void GetFlyDirection()
    {
        Vector3 CamPos = GameCtrl.Instance.MainCamera.transform.position;
        Vector3 ObjPos = transform.parent.position;

        CamPos.x += Random.Range(minCamPos, maxCamPos);
        CamPos.y += Random.Range(minCamPos, maxCamPos);

        Vector3 diff = CamPos - ObjPos;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z);

        Debug.DrawLine(ObjPos, ObjPos + diff * 7, Color.red, Mathf.Infinity);
    }
}
