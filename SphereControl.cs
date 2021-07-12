using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    /*Create a program where you hit the space key and the first sphere falls.When it hits the ground, the sphere turns red and triggers the 2nd sphere. When the 2nd sphere hits the ground, it turns red and triggers the 3rd sphere. When the third sphere hits the ground, it turns all 3 spheres green.*/

    [SerializeField] private GameObject[] _spheres;
    [SerializeField] private Renderer[] _sphereRends;
    [SerializeField] private Rigidbody[] _sphereRigid;
    [SerializeField] private GameObject _floor;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _sphereRigid[0].useGravity = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < _spheres.Length; i++)
        {
            if (_spheres[i] == other.gameObject)
            {
                switch (i)
                {
                    case 0:
                        _sphereRigid[0].useGravity = false;
                        _sphereRigid[0].constraints = RigidbodyConstraints.FreezeAll;
                        _sphereRends[0].material.color = Color.red;
                        _sphereRigid[1].useGravity = true;
                        break;
                    case 1:
                        _sphereRigid[1].useGravity = false;
                        _sphereRigid[1].constraints = RigidbodyConstraints.FreezeAll;
                        _sphereRends[1].material.color = Color.red;
                        _sphereRigid[2].useGravity = true;
                        break;
                    case 2:
                        _sphereRigid[2].useGravity = false;
                        _sphereRigid[2].constraints = RigidbodyConstraints.FreezeAll;
                        for (int j = 0; j < _sphereRends.Length; j++)
                        {
                            _sphereRends[j].material.color = Color.green;
                        }
                        break;
                }
            }

        }


    }



}
