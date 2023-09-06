using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorMateriales : MonoBehaviour
{
    public GameObject []materiales;
    public Transform spawnPoint;

    public void GenerarMaterial(int num)
    {
        if (num == 1)
        {
            Instantiate(materiales[0], spawnPoint.transform.position, spawnPoint.transform.rotation);
        }
        else if (num == 2)
        {
            Instantiate(materiales[1], spawnPoint.transform.position, spawnPoint.transform.rotation);
        }
        else if (num == 3)
        {
            Instantiate(materiales[2], spawnPoint.transform.position, spawnPoint.transform.rotation);
        }
       
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
