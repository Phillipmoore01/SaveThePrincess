using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public enum GameState
    {
         WAITING, PLAYERTURN, ENEMYTURN
    }

public class BattleHandler : MonoBehaviour
{
    [SerializeField] private Transition transition;
    public GameObject p1;
    public GameObject e1;
    public Text information;

    public GameState state;

    void Start()
    {
        state = GameState.WAITING;
        setupBattler();
    }

    void setupBattler(){
        information.text = "The Beepis Attacked";
        state=GameState.PLAYERTURN;
        PlayerTurn();
    }

    void PlayerTurn(){
        information.text = "Players Turn";
    }

    public void attackButton(){
        if(state != GameState.PLAYERTURN){
            return;
        }
        StartCoroutine(Attack());
    }

    IEnumerator Attack(){
        bool status = EnemyController.TakeDamage(999);
        GetComponent<AudioSource>().Play();

        if(status == true){
            information.text = "You deafeted the Beepis Congratualtions";
            yield return new WaitForSeconds(2f);
            transition.fadeToColor("GameScene");
        }
        else{
            information.text = "You attacked the Beepis";
            state=GameState.ENEMYTURN;
            yield return new WaitForSeconds(2f);
            StartCoroutine(Enemyturn());
        }
    }

   IEnumerator Enemyturn(){
        bool status = InGamePlayer.TakeDamage(1);
        information.text = "You were attacked";
        if(state != GameState.ENEMYTURN){
            yield return null;
        }

        if(status == true){
            information.text = "You were deafeted by the Beepis !!!";
            yield return new WaitForSeconds(2f);
            transition.fadeToColor("EndCredits");
        }
        else{
            state=GameState.PLAYERTURN;
            yield return new WaitForSeconds(2f);
            PlayerTurn();
        }
    }

    public void Run(){
        information.text = "You ran from the Beepis";
        transition.fadeToColor("GameScene");
    }
}
