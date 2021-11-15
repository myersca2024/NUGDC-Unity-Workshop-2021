using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = this.transform.position - player.transform.position;
    }

    void Update()
    {
        this.transform.position = player.transform.position + offset;
    }
}
