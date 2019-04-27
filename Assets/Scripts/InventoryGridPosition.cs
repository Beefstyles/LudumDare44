using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryGridPosition : MonoBehaviour
{
    public string InventoryGridPositionLoc;

    public bool GridPositionIsAvailable;
    private Image gridImage;

    void Awake()
    {
        InventoryGridPositionLoc = gameObject.name;
        gridImage = GetComponent<Image>();
        if (GridPositionIsAvailable)
        {
            gridImage.color = Color.gray;
        }
        else
        {
            gridImage.color = Color.black;
        }
    }


}
