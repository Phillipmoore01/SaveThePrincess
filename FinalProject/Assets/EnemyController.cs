using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Transition transition;
    public static int Health = 5;
    [SerializeField] float speed = 0f;

    [SerializeField] int Attack = 1;

    //public static int Health = 5;
    
        public void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Enemy touched");
        
        // Transition to the battle screen
        transition.fadeToColor("BattleScene");
        Destroy(this.gameObject);
    }

    public static void TakeDamage(int pAttack){
        Health -= pAttack;
    }
}
