using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUpTrophy : MonoBehaviour
{

    private bool isPickable; 
    public MeshRenderer mesh;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2") && isPickable == true)
        {
            PickUp();
        }

        if(Input.GetButtonDown("Fire1"))
        {
            mesh.enabled = true;
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPickable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        isPickable = false;
    }

    void PickUp()
    {
        mesh.enabled = false;     
    }
}