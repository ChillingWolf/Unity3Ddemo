using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveCamera:MonoBehaviour
{
    public Transform cameraPosition;

    private void Update() {
        transform.position = cameraPosition.position;
    }
}