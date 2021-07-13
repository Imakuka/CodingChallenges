using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpertPositioner : MonoBehaviour
{
    /*Create a program that allows you to hit 1 one your keyboard and you spawn to position 1. Hit 2 and you spawn to position 2. Hit 3 and you spawn to position 3.*/
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _pos1;
    [SerializeField] private Transform _pos2;
    [SerializeField] private Transform _pos3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.position = _pos1.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position = _pos2.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.position = _pos3.position;
        }
    }
}
