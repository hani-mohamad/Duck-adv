using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aim : MonoBehaviour
{
    public Vector3 mouse;
    public Vector3 worldposition;
    void Update()
    {
        mouse = Input.mousePosition;
        mouse.z = Camera.main.nearClipPlane + 1;

        worldposition = Camera.main.ScreenToWorldPoint(mouse);
        transform.position = worldposition;


    }


}
