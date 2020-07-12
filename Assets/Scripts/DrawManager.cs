using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawManager : MonoBehaviour
{
    public GameObject drawPrefab;
    GameObject theTreail;
    Plane planeObj;
    public Transform pointToDraw;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        planeObj = new Plane(Camera.main.transform.forward * -1, transform.position);
    }
    public Color currentCOlor;
    public GameObject obj;
    bool active = true;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            active = !active;
            obj.gameObject.SetActive(active);
        }
            if (Input.GetMouseButtonDown(0))
            {
                theTreail = (GameObject)Instantiate(drawPrefab, this.transform.position, Quaternion.identity);
                theTreail.GetComponent<TrailRenderer>().startColor = currentCOlor;
                theTreail.GetComponent<TrailRenderer>().endColor = currentCOlor;
                startPos = pointToDraw.position;
                theTreail.transform.position = pointToDraw.position;
            }
            if (Input.GetMouseButton(1))
            {
                theTreail.transform.position = pointToDraw.position;
            }
       
    }
}
