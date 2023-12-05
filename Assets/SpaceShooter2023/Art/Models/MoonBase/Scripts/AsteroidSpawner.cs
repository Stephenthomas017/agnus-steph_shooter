using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroidspawner : MonoBehaviour
{
    [Header("size of the spawner area")]
    public Vector3 spawnerSize;

    [Header("Rate of spawn")]
    public float spawnRate = 1f;

    [Header("Model to spawn")]
    [SerializeField] private GameObject asteroidModel;

    private float spawnTimer = 0f;

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0,1,0,0.5f);
        Gizmos.DrawCube(transform.position, spawnerSize);
    }
    private void update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer > spawnRate)
        {
            spawnTimer = 0;
            SpawnAsteroid();
        }
    }

    private void SpawnAsteroid()
    {
        Vector3 spawnPoint = transform.position + new Vector3(UnityEngine.Random.Range(-spawnerSize.x/2, spawnerSize.x/2),
                                                            UnityEngine.Random.Range(-spawnerSize.y/2, spawnerSize.y/2),
                                                            UnityEngine.Random.Range(-spawnerSize.z/2, spawnerSize.z/2));

        GameObject asteroid = Instantiate(asteroidModel, spawnPoint, transform.rotation);
    }

}