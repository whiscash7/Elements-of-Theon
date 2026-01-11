using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform playerPos;
    Vector3 offset = new Vector3(0.0f, 3f, -5f);

    void Update()
    {
        transform.position = (playerPos.position + offset);
    }
}
