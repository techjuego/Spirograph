using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float FixRadius;
    public float RotateRadius;
    public Transform child;
    public float circumferencefixed;
    public float circumferenceRotate;
    public float roundToMake;
    public float parentAngel;
    void Update()
    {
        circumferencefixed = 2 * Mathf.PI * FixRadius;
        circumferenceRotate = 2 * Mathf.PI * RotateRadius;
        //roundToMake = circumferencefixed / circumferenceRotate;
        roundToMake = FixRadius / RotateRadius;
            if (Input.GetMouseButton(1))
            {
                parentAngel += 1;
            }
            transform.localEulerAngles = new Vector3(0, 0, -parentAngel);
            //  child.transform.localEulerAngles = new Vector3(0, 0, (-parentAngel - 7f) * roundToMake);
            child.transform.localEulerAngles = new Vector3(0, 0, (parentAngel - 14.383f) * roundToMake);
    }
}
