using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSingleton : MonoBehaviour
{
    private static PlayerSingleton instance;

   // public PlayerInput _playerHealth = new pHealth(100);

    void Awake()
    {
        if(instance == null){
            instance = this;
        }else{
            Destroy(this.gameObject);
        }
    }




}
