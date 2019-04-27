using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private int playerSpeed;

    public int PlayerSpeed { get => playerSpeed; set => playerSpeed = value; }

    void Update()
    {
        transform.position += Vector3.right * Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        transform.position += Vector3.up * Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.LookAt(ray.GetPoint(0), Vector3.forward);

        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
        
    }
}
