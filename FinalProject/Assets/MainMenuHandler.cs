using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuHanfdler : MonoBehaviour
{
    [SerializeField] private Transition transition;

     public void Play(){
       transition.fadeToColor("GameScene");
    }

    public void Quit(){
        Application.Quit();
    }
}
