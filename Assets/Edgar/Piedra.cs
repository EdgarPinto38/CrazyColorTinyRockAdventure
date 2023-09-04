using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piedra : MonoBehaviour
{
    private GameObject camaraPrincipal, camaraPiedra;
    private Camera _camMain;
    public Camera camP;


    private void Start()
    {
        camaraPrincipal = GameObject.FindGameObjectWithTag("MainCamera");
        camaraPiedra = GameObject.FindGameObjectWithTag("camPiedra");

        
    }

    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "suelo")
        {
            General.hayPiedra = true;
            Debug.Log("ya esta en el suelo");
            StartCoroutine(ActivarCamaraPrincipal());
            
            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "catapulta")
        {
            General.hayPiedra = true;
            camP.enabled = true;

        }
    }

    IEnumerator ActivarCamaraPrincipal()
    {
        /* yield return new WaitForSeconds(1);
         General.hayPiedra = false;
         camaraPiedra.SetActive(false);
         camaraPrincipal.SetActive(true);
         yield return new WaitForSeconds(1);
         camaraPrincipal.SetActive(false);
         camaraPiedra.SetActive(true);
         Destroy(gameObject);*/
        
        camP.enabled = true;
        yield return new WaitForSeconds(1);
        General.hayPiedra = false;
        camP.enabled = false;
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);



    }
}
