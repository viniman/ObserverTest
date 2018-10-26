using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : Observer
{
    public override void onNotify()
    {
        Debug.Log("Morreu!");
    }
}
