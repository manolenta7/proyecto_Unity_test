using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambioEscenaJuego( string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }

}
