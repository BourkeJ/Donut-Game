using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "floor" || col.tag == "customer")
        {
            Destroy(gameObject);
        }
    }
}
