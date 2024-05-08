using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    [SerializeField] private Transition transition;
   public void Quit(){
        Application.Quit();
    }

    public void Menu()
    {
        transition.fadeToColor("MainMenu");
    }
}
