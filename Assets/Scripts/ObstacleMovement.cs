using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float moveSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
    }
}
