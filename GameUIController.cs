using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUIController : MonoBehaviour
{

    // STEP 3: listen to the event (listener class)


    [SerializeField] private TextMeshProUGUI _playerHealthTextOnUI;

    [SerializeField] private GameObject _gameOverUI;

    // get the reference of player health manager
    private PlayerHealthManager _playerHealthScript;

    // Start is called before the first frame update
    void Start()
    {
        _playerHealthScript = FindObjectOfType<PlayerHealthManager>();


        // subscrive for player died event from player health manager
        PlayerHealthManager.PlayerDied += DisplayGameOver;
    }

    // Update is called once per frame
    void Update()
    {
        //_playerHealthTextOnUI.text = "Health: " + _playerHealthScript.GetPlayerHealth();

        //if (_playerHealthScript.GetPlayerHealth() <= 0)
        //{
        //    _gameOverUI.SetActive(true);
        //}
    }

    private void DisplayGameOver()
    {
        _gameOverUI.SetActive(true);
    }
}
