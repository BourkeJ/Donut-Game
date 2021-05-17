using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private Material _color;
    [SerializeField] private bool _faster = true;
    [SerializeField] private ConveyorMovement _conveyorMovement= null;

    public float _fasterSpeed = 0.001f;
    //[SerializeField] private int _colorPick = 0;

    // To go on gate
    void Start()
    {
        
    }

    
    void OnTriggerEnter(Collider donut)
    {
        if(donut.tag == "donut")
        {
            donut.GetComponent<Renderer>().material = _color;
            if (_faster == true)
            {
                _conveyorMovement.velocity.z += _fasterSpeed;
            }
        }
    }
}
