using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoldScore : MonoBehaviour
{
    public int scoreHolder = 0;
    [SerializeField] private Text _scoreText = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = scoreHolder.ToString();
    }
}
