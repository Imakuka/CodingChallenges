using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerMinion : MonoBehaviour
{
    [SerializeField] private GameObject _minionPrefab;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_minionPrefab, transform);
        }
    }


}
