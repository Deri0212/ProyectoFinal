using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PesticideAnimation : MonoBehaviour
{
    public GameObject Pesticide;
    public GameObject FlowerBase;
    public GameObject Bee;

    public Animator PesticideAnimator;
    public Animator FlowerBaseAnimator;
    public Animator BeeAnimator;

    public void Start(){
        PesticideAnimator = Pesticide.GetComponent<Animator>();
        FlowerBaseAnimator = FlowerBase.GetComponent<Animator>();
        BeeAnimator = Bee.GetComponent<Animator>();
    }
    public void playAnimation (){
        PesticideAnimator.Play("PesticideCanAnimation");
        FlowerBaseAnimator.Play("FlowerBase");
        BeeAnimator.Play("BeeMovement");
    }
}
