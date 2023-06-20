using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, IClickable
{
    private Ability _ability;

    public void SetAbility(Ability pAbility)
    {
        _ability = pAbility;
    }
    public void OnClick()
    {
        if ( _ability != null )
        {
            _ability.Activate();
        }
    }

    public void OnHover()
    {

    }
}
