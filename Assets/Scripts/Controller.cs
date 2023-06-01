using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    protected bool _isTurnFinished = false;
    public bool IsTurnFinished => _isTurnFinished;

    public event System.Action OnTurnFinished;

    public virtual void EnableActions()
    {
        _isTurnFinished = false;
    }

    public virtual void DisableActions()
    {
        _isTurnFinished = true;
        OnTurnFinished?.Invoke();
    }
}
