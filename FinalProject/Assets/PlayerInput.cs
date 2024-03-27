using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
   
    [Header("Fields")]
    [SerializeField] int Health = 100;
    [SerializeField] float speed = 0f;
    [SerializeField] string cName = "Player1";
    [SerializeField] Vector3  homePosition = Vector3.zero;
    [SerializeField] GameObject Point;
    [SerializeField] GameObject Enemy;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //    transform.position += new Vector3(-1,0,0) * Time.deltaTime;
    }

    public void MoveCreature(Vector3 direction){
        rb.velocity = direction*speed;
      //  transform.position += direction * Time.deltaTime * speed;
    }

  //  public void GetPoint(){
  //      GameObject.Find("PointTracker").GetComponent<PointTracker>().RegisterPoint();
//        GetComponent<AudioSource>().Play();
 //   }

    public void MovePlayerTrans(Vector3 direction){
        transform.position += direction * Time.deltaTime * speed;
    }
}
