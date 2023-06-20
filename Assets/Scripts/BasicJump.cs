using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BasicJump : MonoBehaviour
{
    [SerializeField] float _jumpForce;
    
    private bool _canJump = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // basic jump
        if (Input.GetKeyDown(KeyCode.Space) && _canJump)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * _jumpForce);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Tilemap _tileMap = collision.GetComponent<Tilemap>();
        AudioSyncScale _jumpable = collision.GetComponent<AudioSyncScale>();
        if(_tileMap != null || _jumpable != null)
        {
            _canJump = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _canJump = false;
    }

}
