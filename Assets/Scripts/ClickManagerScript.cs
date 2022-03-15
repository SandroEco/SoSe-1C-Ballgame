using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManagerScript : MonoBehaviour
{
    public GameObject ball;
    public Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Vector3 point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0));
            {
                Instantiate(ball, new Vector3(mousePos.x, mousePos.y, 0), Quaternion.identity);

            }
        }
    }

    
}
