using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFalls : MonoBehaviour
{
    ///Create a program that when you hit the space key, the sphere will fall and turn the floor red.When the sphere hits the floor, it should turn the floor blue and the sphere should be destroyed. 
    ///

    [SerializeField] private Rigidbody _sphereRigid;
    [SerializeField] private GameObject _floor;
    [SerializeField] private Renderer _floorRend;

    private void Update()
    {
        //Player input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //sphere will fall by activating gravity
            _sphereRigid.useGravity = true;
            _floorRend.material.color = Color.red;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _floor)
        {
            _sphereRigid.useGravity = false;
            _floorRend.material.color = Color.blue;
            Destroy(this.gameObject);
        }
    }

}
