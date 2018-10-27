using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BallState
{
    public static StandingBallState standingBall = new StandingBallState();
    public static MovingBallState movingBall = new MovingBallState();
    public abstract void hendleInput(BallScript ball, KeyCode key);
}
