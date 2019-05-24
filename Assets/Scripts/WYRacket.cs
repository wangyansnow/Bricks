using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WYRacket : MonoBehaviour
{
    public float speed = 150f;

    private Vector2 lastMousePosition;
    private float leftLimt = -87;
    private float rightLimt = 87;

    private void FixedUpdate()
    {

    }

    private void OnGUI()
    {
        var currentPosition = Event.current.mousePosition;

        if (Event.current.type == EventType.MouseDown)
        {
            lastMousePosition = currentPosition;
            Debug.Log("[WY_Rocket] MouseDown");

        } else if (Event.current.type == EventType.MouseUp)
        {
            Debug.Log("[WY_Rocket] MouseUp");
        } else if (Event.current.type == EventType.MouseDrag)
        {
            var deltaX = currentPosition.x - lastMousePosition.x;
            lastMousePosition = currentPosition;
            Debug.Log("[WY_Rocket] MouseDrag deltaX:" + deltaX);

            var x = transform.position.x + deltaX;
            if (x < leftLimt)
            {
                x = leftLimt;
            } else if (x > rightLimt)
            {
                x = rightLimt;
            }

            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }
    }
}
