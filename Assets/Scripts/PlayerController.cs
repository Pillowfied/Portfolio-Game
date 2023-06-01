using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    private GameObject _target;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                GameObject clickedObject = hit.collider.gameObject;

                if (IsValidTarget(clickedObject))
                {
                    SetTarget(clickedObject);
                }
            }
        }
    }

    bool IsValidTarget(GameObject target)
    {
        return target.GetComponentInChildren<Entity>() != null;
    }

    void SetTarget(GameObject target)
    {
        _target = target;

        Debug.Log("Selected target: " + _target.name);
    }
}
