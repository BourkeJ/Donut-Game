using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapChars : MonoBehaviour
{
    [SerializeField] private GameObject _instantiateDonut = null;
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
                if (hit.collider.tag == "customer")
                {
                    print("ya");
                    GameObject donut = Instantiate(_instantiateDonut, (_instantiateDonut.GetComponent<Transform>().position), Quaternion.identity);
                    
                    Vector3 donutPosition = donut.GetComponent<Transform>().position;
                    donut.GetComponent<Rigidbody>().isKinematic = false;
                    //donut.GetComponent<Transform>().position = Vector3.Lerp(donutPosition, hit.collider.GetComponent<Transform>().position, 20f*Time.deltaTime);
                    donut.GetComponent<Rigidbody>().velocity = (hit.collider.GetComponent<Transform>().position);
                    print(donut.GetComponent<Rigidbody>().velocity);
                }
            }
        }
    }
}
