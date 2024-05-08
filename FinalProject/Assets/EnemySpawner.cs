using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject Beepis;
    
    int count = 0;

    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait(){
        yield return new WaitForSeconds(5);
        StartCoroutine(SpawnerCall());
    }

    IEnumerator SpawnerCall(){
        while(count <= 20){
            Spawn();
            count++;
            yield return new WaitForSeconds(1);
        }
    }

    void Spawn(){
        GameObject BeepisCopy = Instantiate(Beepis, new Vector3(Random.Range(-12,44),Random.Range(-13,40),0), Quaternion.identity);

    }
}
