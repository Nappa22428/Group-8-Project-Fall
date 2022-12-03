using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public Spawner mySpawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        mySpawn.s = true;
    }
}
