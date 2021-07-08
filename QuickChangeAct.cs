using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickChangeAct : MonoBehaviour
{
    /*Create a program that let's you move the Player (sphere) left and right. When you pass through the Color_Change_Wall assign the Player a random color.*/

    [SerializeField] private GameObject _changeWall;
    [SerializeField] private GameObject _player;
    [SerializeField] private Renderer _playerRend;
    [SerializeField] private int _speed = 3;

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontalInput, 0, 0);
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == _changeWall)
        {
            _playerRend.material.color = Random.ColorHSV();
            Debug.Log(other);
        }
    }

}
