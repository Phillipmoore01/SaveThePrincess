using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{

    [SerializeField] private Image fadeImage;
    [SerializeField] private Color fadeColor = Color.black;
    
    [SerializeField] private float fadeTime = 1;
    void Start()
    {
        fadeToClear();
    }

    void fadeToClear(){
        fadeImage.color = fadeColor;
        StartCoroutine(FadetoClearRoutine());
        IEnumerator FadetoClearRoutine(){
            float timer = 0;
            while (timer < fadeTime){
                yield return null;
                timer += Time.deltaTime;
                fadeImage.color = new Color(fadeColor.r,fadeColor.g,fadeColor.b, 1f - (timer/fadeTime));
            }
            fadeImage.color = Color.clear;
        }
    }

    public void fadeToColor(string newScene = ""){
        fadeImage.color = new Color(fadeColor.r,fadeColor.g,fadeColor.b,0);
        StartCoroutine(FadetoColorRoutine());
        IEnumerator FadetoColorRoutine(){
            float timer = 0;
            while (timer < fadeTime){
                yield return null;
                timer += Time.deltaTime;
                fadeImage.color = new Color(fadeColor.r,fadeColor.g,fadeColor.b, 1f - (timer/fadeTime));
            }
            fadeImage.color = fadeColor;
            if(newScene == ""){
                 SceneManager.LoadScene("GameScene");
            }
            else{
                SceneManager.LoadScene("BattleScene");
            }
        }
    }
}

