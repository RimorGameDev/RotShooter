using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        MoveEnemyToPlayer();
    }

    void MoveEnemyToPlayer()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(0, 0, 0), 1.0f * Time.deltaTime);
    }
}
