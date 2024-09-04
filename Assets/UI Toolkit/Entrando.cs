using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Entrando : MonoBehaviour
{
    public GameObject Sphere;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Sphere")
        {
            Sphere.SetActive(true);
        }
    }
    
}