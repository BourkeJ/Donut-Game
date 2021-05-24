using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorMovement : MonoBehaviour
{
    public Vector3 velocity;

    private Rigidbody _rigidBody;
    private Transform _transform;

    

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
        //_rigidBody.velocity = new Vector3(0, 0, -_velocity);
        
    }

    // Update is called once per frame
    void Update()
    {
        _transform.position -= velocity;
        
    }
}
