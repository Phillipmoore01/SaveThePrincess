using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerSpawner : MonoBehaviour
{

    [SerializeField] GameObject Player;
    //[SerializeField] Transform movePoint;
    
    void Start()
    {
    //    StartCoroutine(Wait());
    }
    
    IEnumerator Wait(){
        yield return new WaitForSeconds(5);
        SpawnPlayer();
    }

    public void SpawnPlayer(){
        SpawnPostion();
        Player.SetActive(true);
    }

    public void SpawnPostion(){
        transform.Translate(0f,20f,-2.351785f);
    }
}
