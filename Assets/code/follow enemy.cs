using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followenemy : MonoBehaviour
{
    public GameObject player;
    public float movementSpeed = 5f;
    public float attackRange = 2f;

    void Update()
    {
        if (player == null)
            return;

       
        Vector3 direction = (player.transform.position - transform.position).normalized;
        transform.Translate(direction * movementSpeed * Time.deltaTime);



        if (Vector2.Distance(transform.position, player.transform.position) <= attackRange)
        {
           
        }
    
}
}
