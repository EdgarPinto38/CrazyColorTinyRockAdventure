using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaCambiarNivel : MonoBehaviour
{
    public bool pasarNivel;
    public int indiceNivel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            CambiarNivel(indiceNivel);
        }
        if (pasarNivel)
        {
            CambiarNivel(indiceNivel);
        }*/
    }
    public void CambiarNivel(int indice)
    {
        SceneManager.LoadScene(indice);
    }
    public void Exit()
    {
        Application.Quit();
    }

}
