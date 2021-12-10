using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    private GameController gameController;
    private Vector3 checkpointSpawn;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindObjectOfType<GameController>();
        checkpointSpawn = GetComponentInParent<Checkpoint>().spawnPosition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Checkpoint Reached");
            gameController.SetSpawnPoint(GetComponentInParent<Checkpoint>().spawnPosition);
            gameObject.SetActive(false);
        }

    }
}
