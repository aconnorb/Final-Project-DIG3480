using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public GameObject Camera;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Camera.transform.Translate(new Vector3(15, 0, 0));
        PlayerController.health = 3;
    }
}
