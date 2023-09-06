using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapulta : MonoBehaviour
{
    public GameObject btnPiedra;
    public GameObject btnMaterial;
    public Camera mCamera;
    
    void Start()
    {
        btnPiedra.SetActive(true);
        btnMaterial.SetActive(false);
        
    }

    void Update()
    {
        if (Globals.seGeneroPiedra == 1)
        {
            btnPiedra.SetActive(false);
        }

        if (Globals.estaEnSuelo == true)
        {
            mCamera.enabled = false;
        }
        else if (Globals.activarBTNpiedra==true && Globals.estaEnSuelo ==false)
        {
            mCamera.enabled = true;
            btnPiedra.SetActive(true);
        }
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "piedra")
        {
            btnMaterial.SetActive(true);
        }

        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "piedra")
        {
            Debug.Log("ya se fue");
            StartCoroutine(VolverAposicion());
            

        }
    }

    public IEnumerator VolverAposicion()
    {
        Debug.Log("inicia conteo");
        yield return new WaitForSeconds(2);
        Debug.Log("se regresa a la posicion normal");
        gameObject.transform.position = Vector3.zero;
        gameObject.transform.rotation = Quaternion.identity;
        

    }
}
