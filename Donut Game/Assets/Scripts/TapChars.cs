using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapChars : MonoBehaviour
{
    [SerializeField] private GameObject _instantiateDonut = null;
    [SerializeField] private float _velocity = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select stage    
                if (hit.collider.tag == "customer" || hit.collider.tag == "throwBox")
                {
                    //print("ya");
                    GameObject donut = Instantiate(_instantiateDonut, (_instantiateDonut.GetComponent<Transform>().position + Vector3.up), Quaternion.identity);
                    
                    Vector3 donutPosition = donut.GetComponent<Transform>().position;
                    donut.GetComponent<Rigidbody>().isKinematic = false;
                    donut.tag = "notNut";
                    //donut.GetComponent<Transform>().position = Vector3.Lerp(donutPosition, hit.collider.GetComponent<Transform>().position, 20f*Time.deltaTime);
                    Vector3 direction = (hit.collider.GetComponent<Transform>().position - donutPosition).normalized;
                    donut.GetComponent<Rigidbody>().velocity = direction * _velocity;
                    //print(donut.GetComponent<Rigidbody>().velocity);
                }
            }
        }
    }
}
