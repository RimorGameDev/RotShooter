using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnProjecttiles : MonoBehaviour
{
    public GameObject projecttile;
    void Start()
    {
        
    }

    
    void Update()
    {
        GetMouseClickDown();
    }

    void GetMouseClickDown()
    {
        if(Input.GetMouseButtonDown(button: 0))
        {
            spawnTheProjecttileVoid();
        }
    }

    void spawnTheProjecttileVoid()
    {
        GameObject projecttileClone;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        projecttileClone = Instantiate(projecttile,transform.position,Quaternion.Euler(0, 0, transform.eulerAngles.z)) as GameObject;
        Rigidbody projecttileRigidbody = projecttileClone.AddComponent<Rigidbody>();
        projecttileRigidbody.velocity = mousePosition * 4.0f;
        projecttileRigidbody.useGravity = false;
    }
}
