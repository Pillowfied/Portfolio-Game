using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour, IClickable
{
    // Stats
    protected int _health;
    protected int _mana;
    protected int _armor;
    protected int _magicResistance;
    protected int _strength;
    protected int _wisdom;
    protected int _speed;

    protected StatusEffect[] _statusEffects;
    // protected Abilities[] _abilities;

    void Start()
    {

    }

    // Update is called once per frame
    public virtual void Update()
    {
        Vector2 _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        bool _isHovering = GetComponent<Collider2D>().OverlapPoint(_mousePos);
        if (Input.GetMouseButtonDown(0) && _isHovering)
        {
            OnClick();
        }

        if (_isHovering)
        {
            OnHover();
        }
    }

    public virtual void OnClick()
    {
        Debug.Log("Entity Clicked");
    }

    public virtual void OnHover()
    {
        Debug.Log("Entity Hovered");
    }
}
