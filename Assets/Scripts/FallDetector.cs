using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetector : MonoBehaviour
{
    private Vector3 respawnPoint;
    [SerializeField] private Transform player;

    void Awake()
    {
        respawnPoint = player.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player has fallen down");
        if (other.CompareTag("Player")){
            player.transform.position = respawnPoint;
            Physics.SyncTransforms();
        }
    }
}
