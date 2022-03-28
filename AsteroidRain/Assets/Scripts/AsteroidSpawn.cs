using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public Vector3 size;

    public float spawnRate = 1f;
    public GameObject aModel;

    public Transform asteroidParent;

    private float nextSpawn = 0;

    public void OnDrawGizmos()
    {
        Gizmos.color = new Color(0,1,0,0.5f);
        Gizmos.DrawCube(transform.position, size);
    }

    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            SpawnAsteroid();
        }
    }

    private void SpawnAsteroid()
    {
        Vector3 spawnPoint = transform.position + new Vector3(UnityEngine.Random.Range(-size.x / 2, size.x / 2), UnityEngine.Random.Range(-size.y / 2, size.y / 2), UnityEngine.Random.Range(-size.z / 2, size.z / 2));

        Quaternion asteroidRotation = Quaternion.Euler(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360));

        GameObject asteroid = Instantiate(aModel, spawnPoint, asteroidRotation);

        asteroid.transform.SetParent(asteroidParent);
    }
}
