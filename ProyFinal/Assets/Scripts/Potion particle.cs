using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class Potionparticle : MonoBehaviour
{
    public ParticleSystem misparticulas;

    public void Iniciar(){
        misparticulas.Play();
    }

    public void Detener(){
        misparticulas.Stop();
    }
}
