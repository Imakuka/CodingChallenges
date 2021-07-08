using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyLevelSelector : MonoBehaviour
{
    [HideInInspector]
    public int arrayIDX = 0;
    [HideInInspector]
    public string[] myArray = new string[] { "Easy", "Medium", "Hard", "Imposible" };

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (arrayIDX)
            {
                case 0:
                    print("You have selected Easy");
                    break;
                case 1:
                    print("You have selected Medium");
                    break;
                case 2:
                    print("You have selected Hard");
                    break;
                case 3:
                    print("You have selected Impossible");
                    break;

            }

        }
    }
}
