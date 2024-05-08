using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameMenu : MonoBehaviour
{
    [SerializeField] private Transition transition;
    
    public void Return()
    {
        transition.fadeToColor("MainMenu");
    }
    public void Battle()
    {
        transition.fadeToColor("BattleScene");
    }
    public void Quit(){
        Application.Quit();
    }
}
