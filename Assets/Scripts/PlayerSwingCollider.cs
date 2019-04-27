using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwingCollider : MonoBehaviour
{
    public GameObject SwingRadiusGO = null;
    Resource resource;

    void OnTriggerEnter(Collider coll)
    {
        if(SwingRadiusGO == null && coll.gameObject.tag == "ActionObject")
        {
            SwingRadiusGO = coll.gameObject;
        }
    }

    void OnTriggerExit(Collider coll)
    {
        SwingRadiusGO = null;
    }

    public void SwingObject(string objectType)
    {
        resource = SwingRadiusGO.GetComponent<Resource>();
        if(resource != null)
        {
            switch (resource.ActionToObject)
            {
                case (ActionToObject.Digup):
                    switch (resource.ObjectType)
                    {
                        case (PickupableObject.RadDust):
                            if(objectType == "Shovel")
                            {
                                Debug.Log("Dug Rad Dust");
                                Destroy(SwingRadiusGO);
                                resource = null;
                                SwingRadiusGO = null;
                            }
                            break;
                    }
                    break;
            }
        }
        else
        {
            Debug.LogError("Object is in the swing radius but doesn't have a resource script attached!");
        }
    }

}
