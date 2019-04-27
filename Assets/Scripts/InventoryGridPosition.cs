using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGridPosition : MonoBehaviour
{
    public string InventoryGridPositionLoc;

    public bool GridPositionIsAvailable;
    private SpriteRenderer sr;

    void Awake()
    {
        InventoryGridPositionLoc = gameObject.name;
        sr = GetComponent<SpriteRenderer>();
        if (GridPositionIsAvailable)
        {
            sr.color = Color.gray;
        }
        else
        {
            sr.color = Color.black;
        }
    }


}
