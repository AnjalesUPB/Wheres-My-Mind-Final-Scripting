using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateController : MonoBehaviour
{
    void StateMachine(int type)
    {
        switch (type)
        {
            case 1:
                Slow();
                break;
            case 2:
                Root();
                break;
            case 3:
                Drunk();
                break;

            default:
                break;
        }
    }

    void Slow()
    {
        move.speed = lostSpeed;
        Sprite(0);
    }

    void Root()
    {
        move.speed = 0;
        animator.SetBool("isDancing", true);
        Sprite(2);
    }

    void Drunk()
    {
        move.speed = -temp;
        Sprite(3);
    }
}
