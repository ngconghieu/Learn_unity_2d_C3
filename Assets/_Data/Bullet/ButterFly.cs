using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterFly : ParentFly
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.moveSpeed = 7;
    }
}
