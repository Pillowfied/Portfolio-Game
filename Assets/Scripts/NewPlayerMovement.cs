using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerMovement : MonoBehaviour
{
    [SerializeField] float _speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // basic movement
        float x = Input.GetAxis("Horizontal");
        Vector2 _movement = new Vector2(x, 0f) * _speed;
        transform.Translate(_movement * Time.deltaTime);
    }
}
