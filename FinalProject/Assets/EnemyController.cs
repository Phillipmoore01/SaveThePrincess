using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Transition transition;
    public static int Health = 20;
    [SerializeField] float speed = 0f;
    public static int currentHP = 20;

    [SerializeField] int Attack = 1;
    
    public void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Enemy touched");
        
        transition.fadeToColor("BattleScene");
        Destroy(this.gameObject);
    }

    public static bool TakeDamage(int pAttack){
        currentHP = currentHP - pAttack;
        if(currentHP <= 0){
            return true;
            Debug.Log(currentHP);
        }
        else
            return false;
    }
}
