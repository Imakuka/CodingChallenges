using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeCubes : MonoBehaviour
{
    [SerializeField] private Renderer[] _cubeRends;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = 0; i < _cubeRends.Length; i++)
            {
                foreach(var rend in _cubeRends)
                {
                    _cubeRends[i].material.color = Color.red;
                }
            }
        }
    }
}
