using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPiedras : MonoBehaviour
{
    public GameObject []piedra;
    public Transform spawnPoint;

    public void GenerarPiedra(int num)
    {
        if (num==1)
        {
            Instantiate(piedra[0], spawnPoint.transform.position, spawnPoint.transform.rotation);
            Globals.seGeneroPiedra = 1;
        }
        else if (num==2)
        {
            Instantiate(piedra[1], spawnPoint.transform.position, spawnPoint.transform.rotation);
            Globals.seGeneroPiedra = 1;
        }
        else if (num==3)
        {
            Instantiate(piedra[2], spawnPoint.transform.position, spawnPoint.transform.rotation);
            Globals.seGeneroPiedra = 1;
        }
        
        
    }
}
