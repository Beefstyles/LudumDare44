using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairChange : MonoBehaviour
{
    public Sprite DefaultCursor;
    public Sprite PickupCursor;
    public Sprite DigCursor;
    public Sprite AttackCursor;
    public CursorMode curMode;
    public Vector2 HotSpot = Vector2.zero;
    private Resource clickableResource;


    void Start()
    {
        SetDefaultCursor();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray;
            RaycastHit hit;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.tag);
            }
        }
    }

    void OnMouseEnter()
    {
        Debug.Log(gameObject.tag);
        if (gameObject.tag == "ActionObject")
        {
            Ray ray;
            RaycastHit hit;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                clickableResource = hit.collider.GetComponent<Resource>();
                Debug.Log("Hit " + clickableResource.ActionToObject);
                if (clickableResource != null)
                {
                    switch (clickableResource.ActionToObject)
                    {
                        case (ActionToObject.Digup):
                            SetDigCursor();
                            break;
                        case (ActionToObject.Pickup):
                            SetPickupCursor();
                            break;
                        case (ActionToObject.Attack):
                            SetAttackCursor();
                            break;
                        case (ActionToObject.NoAction):
                            SetDefaultCursor();
                            break;
                    }
                    
            }
            }
            
            
            Cursor.SetCursor(DigCursor.texture, HotSpot, curMode);
        }
    }

    void OnMouseExit()
    {
        SetDefaultCursor();
    }

    void SetDefaultCursor()
    {
        Cursor.SetCursor(DefaultCursor.texture, HotSpot, curMode);
    }

    void SetDigCursor()
    {
        Cursor.SetCursor(DigCursor.texture, HotSpot, curMode);
    }

    void SetPickupCursor()
    {
        Cursor.SetCursor(PickupCursor.texture, HotSpot, curMode);
    }

    void SetAttackCursor()
    {
        Cursor.SetCursor(AttackCursor.texture, HotSpot, curMode);
    }

}
