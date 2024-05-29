using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowObjectOnTrigger : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject Trigger;

    private void OnTriggerEnter(Collider other) {
        Instantiate(Prefab, new Vector3(5.21999979f,-0.550000012f,-56.8300018f), Quaternion.identity);
        Destroy(Trigger);
    }
}

