using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResetColumnPosition : MonoBehaviour
{
    public Transform transfrmToReset;
    public Vector3 startingPosition;
    public Vector3 startingRotationAngles;
    public Quaternion startingRotation;

    // Start is called before the first frame update
    void Start()
    {
        if (transfrmToReset == null)
        {
            transfrmToReset = transform;
        }

        startingPosition = transfrmToReset.position;
        startingRotation = transfrmToReset.rotation;
        startingRotationAngles = transfrmToReset.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            transfrmToReset.position = startingPosition;
            transfrmToReset.rotation = startingRotation;
            transfrmToReset.eulerAngles = startingRotationAngles;
        }
    }
}
