using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefab;
    public bool s = false;
    // public float spawnRate = 1f;
    //public float minHeight = -1f;
    //public float maxHeight = 2f;

    public void Start()
    {
        Spawn();
    }

    public void Awake()
    {
        Spawn();
    }
    private void Update()
    {
        if (s == true)
        {
            Spawn();
            s = false;
        }
    }
    /*
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);

    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    */
    private void Spawn()
    {
        GameObject obstacle = Instantiate(prefab[Random.Range(0, prefab.Length)], transform.position, Quaternion.identity);
        //pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);

    }

    public void sTrue()
    {
        s = true;
    }
}
