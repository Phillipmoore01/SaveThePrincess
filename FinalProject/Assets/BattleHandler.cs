using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    [SerializeField] private Transition transition;
    public GameObject p1;
    public GameObject e1;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Attack(){
        EnemyController.TakeDamage(1);
        Debug.Log("You attacked the Big Meepis");
    }

    public void Run(){
        transition.fadeToColor("GameScene");
    }
}
