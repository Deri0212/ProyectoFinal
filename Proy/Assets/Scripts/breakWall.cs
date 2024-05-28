using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakWall : MonoBehaviour
{
    public GameObject Object;

    public void OnButtonClick()
        {
            Destroy(Object);
        }
}

