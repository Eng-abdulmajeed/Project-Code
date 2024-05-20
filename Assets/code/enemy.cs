using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
    public int maxhealth = 3;
    int currenthealth;

    public Animator anm;

 
    void Start()
    {
        currenthealth = maxhealth; 
    }

   public void takedamge(int damge)
    {
        currenthealth-=damge;
        anm.SetTrigger("hurt");

        if (currenthealth <= 0 )
        {
            die();
        }

    }
    void die()
    {

        

        this.enabled = false;
        GetComponent<Collider2D>().enabled = false;

    }
}
