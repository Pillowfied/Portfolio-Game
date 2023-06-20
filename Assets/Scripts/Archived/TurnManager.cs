using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    [SerializeField] GameObject[] _players;
    [SerializeField] GameObject[] _enemies;

    private int _currentTurnIndex = 0;
    private bool _isPlayerTurn = false;

    // Start is called before the first frame update
    void Start()
    {
        _isPlayerTurn = true;
        StartNextTurn();
        foreach (GameObject player in _players)
        {
            player.GetComponent<PlayerController>().SetTurnManager(this);
        }
        foreach (GameObject enemy in _enemies)
        {
            enemy.GetComponent<EnemyController>().SetTurnManager(this);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (_isPlayerTurn && _players[_currentTurnIndex].GetComponent<PlayerController>().IsTurnFinished)
        {
            SwitchTurn();
        }
        else if (!_isPlayerTurn && _enemies[_currentTurnIndex].GetComponent<EnemyController>().IsTurnFinished)
        {
            SwitchTurn();
        }
    }

    void StartNextTurn()
    {
        if (_isPlayerTurn)
        {
            _players[_currentTurnIndex].GetComponent<PlayerController>().EnableActions();
        }
        else
        {
            _enemies[_currentTurnIndex].GetComponent<EnemyController>().EnableActions();
        }
    }

    void SwitchTurn()
    {
        if (_isPlayerTurn)
        {
            _players[_currentTurnIndex].GetComponent<PlayerController>().DisableActions();
        }
        else
        {
            _enemies[_currentTurnIndex].GetComponent<EnemyController>().DisableActions();
        }

        _currentTurnIndex++;
        if (_currentTurnIndex >= _players.Length)
        {
            _currentTurnIndex = 0;
        }

        _isPlayerTurn = !_isPlayerTurn;

        StartNextTurn();
    }
}
