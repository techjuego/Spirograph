using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    public Color materialColor = Color.white;
    private void OnEnable()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
    private void OnMouseDown()
    {
        foreach (Transform item in transform.parent)
        {
            item.GetComponent<SpriteRenderer>().enabled = false;
        }
        GetComponent<SpriteRenderer>().enabled = true;
        FindObjectOfType<DrawManager>().currentCOlor = materialColor;
        FindObjectOfType<DrawManager>().pointToDraw = transform;
    }
}
