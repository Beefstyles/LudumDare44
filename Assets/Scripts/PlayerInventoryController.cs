using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryController : MonoBehaviour
{
    InventoryGridPosition[] inventoryGridPositions;
    PlayerInventory playerInventory;
    public int MaxX, MaxY;
    
    void Awake()
    {
        playerInventory = FindObjectOfType<PlayerInventory>();
        inventoryGridPositions = GetComponentsInParent<InventoryGridPosition>();
        for (int x = 0; x <= MaxX; x++)
        {
            for (int y = 0; y <= MaxY; y++)
            {
                foreach (var gridPos in inventoryGridPositions)
                {
                    string loc = string.Format("{0},{1}", x, y);
                    if (gridPos.InventoryGridPositionLoc == loc)
                    {
                        gridPos.GridPositionIsAvailable = true;
                    }

                }
            }
        }
    }

    void Update()
    {
        
    }
}
