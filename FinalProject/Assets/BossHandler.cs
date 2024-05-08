using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHandler : MonoBehaviour
{
    [SerializeField] private Transition transition;

    public void OnTriggerEnter2D(Collider2D other){
        //Debug.Log("Enemy touched");
        
        transition.fadeToColor("FinalBossScene");
        Destroy(this.gameObject);
    }
}
