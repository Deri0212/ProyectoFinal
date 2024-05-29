using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GuideMovement : MonoBehaviour
{

    public GameObject GuideBee;
    public GameObject GuideCanva;
    public GameObject NextGuideCanva;
    public Animator GuideBeeAnimator;



    public void Start(){
        GuideBeeAnimator = GuideBee.GetComponent<Animator>();
    }
    public void continueGuide(string animation){
        GuideCanva.SetActive(false);
        GuideBeeAnimator.Play(animation);
        NextGuideCanva.SetActive(true);
    }

}
