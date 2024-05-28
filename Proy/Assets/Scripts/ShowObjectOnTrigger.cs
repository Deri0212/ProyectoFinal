using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowObjectOnTrigger : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject Trigger;

    private void OnTriggerEnter(Collider other) {
        Instantiate(Prefab, new Vector3(4.78000021f,-0.76700002f,-51.0499992f), Quaternion.identity);
        Destroy(Trigger);
    }
}

