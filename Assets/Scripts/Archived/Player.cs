using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    [SerializeField] int _health;
    [SerializeField] int _armor;
    [SerializeField] int _strength;
    [SerializeField] int _intellect;

    [SerializeField] Ability[] _abilities;
    void Start()
    {

    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    public override void OnClick()
    {

    }

    public override void OnHover()
    {

    }
}
