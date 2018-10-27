using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingBallState : BallState
{
    public override void hendleInput(BallScript ball, KeyCode key)
    {
        if(key == KeyCode.RightArrow || key == KeyCode.LeftArrow || key == KeyCode.UpArrow || key == KeyCode.DownArrow)
        {
            ball.ballState = BallState.movingBall;
        }
    }
}
