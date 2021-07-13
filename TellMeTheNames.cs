using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TellMeTheNames : MonoBehaviour
{

    /*Create a program that allows you to input 5 names into the inspector.When you hit the "Space" key, print out all 5 names.I should be allowed to specify in the inspector how many names i'd like to enter. For example, 1,000 names and when I hit "Space" it will print out all 1,000 names.*/

    [SerializeField] private string[] _names;
    [SerializeField] private int _numberOfNames;

    private void Start()
    {
        NameGenerator(_numberOfNames);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < _names.Length; i++)
            {
                foreach (var name in _names)
                {
                    print("" + name);
                }
            }
        }
    }

    private void NameGenerator(int numberOfNames)
    {
        _names = new string[numberOfNames];
    }


}
