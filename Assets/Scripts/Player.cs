using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    // Start is called before the first frame update
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
        Debug.Log("Player Clicked.");
    }

    public override void OnHover()
    {

    }
}