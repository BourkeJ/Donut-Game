using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSpot : MonoBehaviour
{
    [SerializeField] private ConveyorMovement _conveyorMovement = null;

    [SerializeField] private GameObject _youWin = null;
    [SerializeField] private string _sceneName = "";
    [SerializeField] private float _sceneTimer = 5f;

    private bool _won = false;

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
            _won = true;
        }
    }

    void Update()
    {
        if(_won == true)
        {
            _sceneTimer -= Time.deltaTime;
            if(_sceneTimer <= 0f)
            {
                SceneManager.LoadScene(_sceneName);
            }
        }
    }
}
