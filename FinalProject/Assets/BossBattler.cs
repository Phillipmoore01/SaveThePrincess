using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 /*  public enum GameState
    {
         WAITING, PLAYERTURN, ENEMYTURN
    }
*/
public class BossBattler : MonoBehaviour
{
    [SerializeField] private Transition transition;
    public GameObject p1;
    public GameObject e1;
    public Text information;
    public bool done = false;

    public GameState state;

    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait(){
        yield return new WaitForSeconds(5);
        state = GameState.WAITING;
        setupBattler();
    }

    void setupBattler(){
        //information.text = "You were attacked by the Imp";
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
        bool status = BossCon.TakeDamage(999);
        GetComponent<AudioSource>().Play();

        if(status == true){
            information.text = "You deafeted this Imp!!";
            yield return new WaitForSeconds(2f);
            transition.fadeToColor("EndCredits");
        }
        else{
            information.text = "You attacked the Imp";
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
            information.text = "You were deafeted by the Timp";
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
        information.text = "YOU CAN'T RUN FROM ME";
    }
}


