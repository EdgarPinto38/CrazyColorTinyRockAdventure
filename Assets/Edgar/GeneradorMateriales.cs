using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorMateriales : MonoBehaviour
{
    public GameObject material1;
    public Transform spawnPoint;

    public void GenerarMaterial1()
    {
        Instantiate(material1, spawnPoint.transform.position, spawnPoint.transform.rotation);
        
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
