using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGamePlayer : MonoBehaviour
{
    
    public static int Health = 100;
    [SerializeField] GameObject Enemy;
    public static int currentHP = 100;




    public static bool TakeDamage(int pAttack){
        Health -= pAttack;
        if(currentHP <= 0){
            return true;
        }
        else
            return false;
    }

}
