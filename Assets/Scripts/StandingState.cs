using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingState : State
{
    public override void hendleInput(BallScript ball, KeyCode key)
    {
        if(key == KeyCode.RightArrow || key == KeyCode.LeftArrow || key == KeyCode.UpArrow || key == KeyCode.DownArrow)
        {
            ball.State = State.MovingSate;
        }
    }
}
