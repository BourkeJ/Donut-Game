using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSet : MonoBehaviour
{
    [SerializeField] private Renderer _bottomRend = null;

    private Renderer _topRend= null;

    // Start is called before the first frame update
    void Awake()
    {
        _topRend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _topRend.material.color = _bottomRend.material.color;
    }
}
