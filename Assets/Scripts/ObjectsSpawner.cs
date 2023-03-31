using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    public GameObject chair;
    public GameObject couch;
    public GameObject table;
    private Placement placementIndicatorManager;
    public GameObject plane;
    private Vector3 scaleChange = new Vector3(0.1f, 0.1f, 0.1f);


    // Start is called before the first frame update
    void Start()
    {
        placementIndicatorManager = FindObjectOfType<Placement>();
    }
    private void Update()
    {
        obj.transform.position = placementIndicatorManager.transform.position;
    }
    // Update is called once per frame
    /*void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(gameObject, placementIndicatorManager.transform.position, placementIndicatorManager.transform.rotation);
        }
    }*/
    public void spawnChair()
    {
        Destroy(obj);
        obj = Instantiate(chair, placementIndicatorManager.transform.position, placementIndicatorManager.transform.rotation);
    }
    public void spawnTable()
    {
        Destroy(obj);
        obj = Instantiate(table, placementIndicatorManager.transform.position, placementIndicatorManager.transform.rotation);
    }
    public void spawnCouch()
    {
        Destroy(obj);
        obj = Instantiate(couch, placementIndicatorManager.transform.position, placementIndicatorManager.transform.rotation);
    }
    public void Destruct()
    {
        Destroy(obj);
    }
    public void RotatePlus()
    {
        obj.transform.Rotate(placementIndicatorManager.transform.rotation.x, placementIndicatorManager.transform.rotation.y + 90f, placementIndicatorManager.transform.rotation.z);
    }
    public void RotateMoins()
    {
        obj.transform.Rotate(placementIndicatorManager.transform.rotation.x, placementIndicatorManager.transform.rotation.y - 90f, placementIndicatorManager.transform.rotation.z);
    }
    public void ScalePlus()
    {
        obj.transform.localScale += scaleChange;
    }
    public void ScaleMoins()
    {
        obj.transform.localScale -= scaleChange;
    }
    public void blue()
    {
        var planeRender = plane.GetComponent<Renderer>();
        planeRender.material.SetColor("_Color", Color.blue);
    }
    public void red()
    {
        var planeRender = plane.GetComponent<Renderer>();
        planeRender.material.SetColor("_Color", Color.red);
    }
    public void green()
    {
        var planeRender = plane.GetComponent<Renderer>();
        planeRender.material.SetColor("_Color", Color.green);
    }

}
