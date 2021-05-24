using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSpot : MonoBehaviour
{
    [SerializeField] private ConveyorMovement _conveyorMovement = null;

    [SerializeField] private GameObject _youWin = null;

    void Awake()
    {
        _youWin.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "donutBox")
        {
            _conveyorMovement.velocity = Vector3.zero;
            print("dang");
            _youWin.SetActive(true);
        }
    }
}
