using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    private GameObject _target;
    private TurnManager _turnManager;

    public GameObject Target
    {
        get { return _target; }
    }
    public void SetTurnManager(TurnManager pTurnManager)
    {
        _turnManager = pTurnManager;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(_mousePos, Vector2.zero);
            if (hit.collider != null)
            {
                GameObject _clickedObject = hit.collider.gameObject;

                if (IsValidTarget(_clickedObject))
                {
                    SetTarget(_clickedObject);
                }
            }
        }
    }

    bool IsValidTarget(GameObject pTarget)
    {
        return pTarget.GetComponentInChildren<Entity>() != null;
    }

    void SetTarget(GameObject pTarget)
    {
        _target = pTarget;
        Debug.Log("Selected target: " + _target.name);
    }
}
