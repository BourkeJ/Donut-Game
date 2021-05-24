using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharLeave : MonoBehaviour
{
    private Material _customerMaterial = null;
    private Animator _animator = null;

    [SerializeField] private HoldScore _holdScore = null;

    // Start is called before the first frame update
    void Awake()
    {
        _customerMaterial = GetComponent<Renderer>().material;
        _animator = GetComponent<Animator>();
        //print(_customerMaterial);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider donut)
    {
        //gameObject.tag = "notNut";

        if(donut.GetComponent<Renderer>().material.color == _customerMaterial.color && _customerMaterial.color != Color.white && _customerMaterial.color != Color.black)
        {
            //_animator.SetBool("Good", true);
            _customerMaterial.SetColor("_Color", Color.white);
            _holdScore.scoreHolder += 1;
            //print("yayyyyyy");
        }
        else if(donut.GetComponent<Renderer>().material.color != _customerMaterial.color && _customerMaterial.color != Color.white && _customerMaterial.color != Color.black)
        {
            //_animator.SetBool("Bad", true);
            _customerMaterial.SetColor("_Color", Color.black);
            _holdScore.scoreHolder -= 1;
            //print("ouchies");
        }
    }
}
