using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Entity
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
        Debug.Log("Skeleton clicked");
    }

    public override void OnHover()
    {
        //Debug.Log("Skeleton Hovered");
    }
}
