using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] PlayerInput something;
    
    void Update()
    {
        Vector3 input = Vector3.zero;

        if(Input.GetKey(KeyCode.W)){
            input.y = 1;
        }

        if(Input.GetKey(KeyCode.S)){
            input.y = -1;
        }

        if(Input.GetKey(KeyCode.A)){
            input.x = -1;
        }

        if(Input.GetKey(KeyCode.D)){
            input.x = 1;
        }

        something.MovePlayerTransform(input);
        something.MoveCreature(input);
    }
    
}
