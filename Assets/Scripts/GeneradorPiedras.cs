using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPiedras : MonoBehaviour
{
    public GameObject piedra1;
    public Transform spawnPoint;

    public void GenerarPiedra()
    {
        Instantiate(piedra1,spawnPoint.transform.position,spawnPoint.transform.rotation);
        Globals.seGeneroPiedra = 1;
        
    }
}
