using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
   
    [Header("Fields")]
    [SerializeField] float speed = 0f;
    [SerializeField] string cName = "Player1";
    [SerializeField] Vector3  homePosition = Vector3.zero;
    [SerializeField] GameObject Enemy;
    [SerializeField] GameObject Player;
    public int _health = 100;
    public Transform movePoint;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    public void MoveCreature(Vector3 direction){
       rb.velocity = direction*speed;
    }

    public void MovePlayerTransform(Vector3 direction){
        transform.position += direction * Time.deltaTime * speed;
    }

    public PlayerInput(int health){
        _health = health;
    }
}
