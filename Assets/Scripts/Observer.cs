using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// nao pode herdar de monobehavior que é especifico da unity
public abstract class Observer
{
    public abstract void onNotify();
}
