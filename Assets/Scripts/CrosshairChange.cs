using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairChange : MonoBehaviour
{
    public Texture2D DefaultTexture;
    public Texture2D PickUpTexture;
    public Texture2D DigTexture;
    public CursorMode curMode;
    public Vector2 HotSpot = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        if(gameObject.tag == "DigSpot")
        {
            Cursor.SetCursor(DigTexture, HotSpot, curMode);
        }
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(DefaultTexture, HotSpot, curMode);
    }
}
