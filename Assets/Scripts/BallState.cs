using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    public static StandingState standing = new StandingState;
    public static MovingState moving = new MovingState;
    public abstract void hendleInput(BallScript ball, KeyCode key);
}
