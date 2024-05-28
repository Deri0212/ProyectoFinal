using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccionBoton : MonoBehaviour
{
    public void cambiarEscena(int escena){
        SceneManager.LoadScene(escena);
    }
    public void salir(){
        Application.Quit();
    }
}

