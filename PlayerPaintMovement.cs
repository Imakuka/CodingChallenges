using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaintMovement : MonoBehaviour
{
    [SerializeField] private int _speed = 3;
    [SerializeField] private GameObject _paintDotPrefab;
    [SerializeField] private Renderer _dotRend;
    [SerializeField] private bool _isPlayerMoving = false;


    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        StartCoroutine(PaintRoutine());

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
           _isPlayerMoving = true;

        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            _isPlayerMoving = false;
        }

    }

    private void PlayerMovement()
    {

        var horizontalMove = Input.GetAxis("Horizontal");
        var verticalMove = Input.GetAxis("Vertical");
        var direction = new Vector3(horizontalMove, 0, verticalMove);
        transform.Translate(direction * _speed * Time.deltaTime);



    }

    private IEnumerator PaintRoutine()
    {
        if(_isPlayerMoving == true)
        {
            var newDrop = Instantiate(_paintDotPrefab);
            newDrop.transform.position = transform.position;
            newDrop.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
            yield return new WaitForSeconds(1);
        }

    }
}
