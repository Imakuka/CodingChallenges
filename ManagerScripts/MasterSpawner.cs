using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterSpawner : MonoBehaviour
{
    /*Click on the Spawn_Manager.You'll see that it's populated with 4 gameObjects repeatedly. This is a "poor" implementation of having these objects spawn randomly.

      Goal: Optomize the SpawnManager script to spawn 4 prefabs randomly every 2 seconds.

      Hint: There is no need to have to maintain a list of duplicate items in our array.*/

    [SerializeField] private GameObject[] _objectsToSpawn;

    private void Start()
    {
        StartCoroutine(SpawnRandomRoutine());
    }

    private IEnumerator SpawnRandomRoutine()
    {
        while (true)
        {
            var newObject = Instantiate(_objectsToSpawn[Random.Range(0, 3)]);
            newObject.transform.position = transform.position;
            yield return new WaitForSeconds(2);
        }
    }

}
