using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{

    [SerializeField] private float damping;

    public Transform target;

    private Vector3 vel = Vector3.zero;

    public void FixedUpdate(){
        Vector3 targetPosition = target.position;
        targetPosition.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel,
        damping);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
