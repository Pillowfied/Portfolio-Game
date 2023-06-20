using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    [SerializeField] private int _sceneIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        NewPlayerMovement _player = collision.GetComponent<NewPlayerMovement>();
        if (_player != null)
        {
            SceneManager.LoadScene(_sceneIndex);
        }
    }
}
