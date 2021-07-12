using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIManagerPlayerStats : MonoBehaviour
{

    private static UIManagerPlayerStats _instance;
    public static UIManagerPlayerStats Instance
    {
        get
        {
            if (_instance == null)
                Debug.Log("UI Manager is NULL");
            return _instance;
        }
    }

    /*Create a program that displays the players stats.Attached to the Player is a script where you can customize the fields. When you run the game, they should populate below by grabing the information found on the Player object. Create a UIManager class and attach it to the Canvas.Do NOT modify the Player.cs*/
    [SerializeField] private Text[] _playerStats;


    private void Awake()
    {
        _instance = this;
    }

    private void OnEnable()
    {
        //Player.onStartStats += OnStartStats;
    }

    public void OnStartStats(GameObject player)
    {
       /*var newPlayer = player.gameObject.GetComponent<Player>();
        _playerStats[0].text = "Player Name: " + newPlayer.playerName;
        _playerStats[1].text = "Attack Level: " + newPlayer.attackLevel;
        _playerStats[2].text = "Magic Level: " + newPlayer.magicLevel;
        _playerStats[3].text = "Smithing Level: " + newPlayer.smithingLevel;
        _playerStats[4].text = "Mining Level: " + newPlayer.miningLevel;*/

    }


    private void OnDisable()
    {
        //Player.onStartStats -= OnStartStats;
    }
    



}
