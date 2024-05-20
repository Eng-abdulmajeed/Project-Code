using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class litattack : MonoBehaviour
{
    public Animator anm;

    public Transform attackpoint;
    public float attackrange = 0.5f;
    public LayerMask enemylayers;

    public int attackdamge=40;

    public float atttackrate = 3f;
    float nextattacktime = 0f;
    

    // Update is called once per frame
    void Update()
    {
       if(Time.time >= nextattacktime)
       {
         if (Input.GetKeyDown(KeyCode.E))
        {
            litAttack();
                nextattacktime = Time.time + 1f / atttackrate;
        }
        
       }
    }

    void litAttack ()
    {
        anm.SetTrigger("lit attack");

        Collider2D[] hitenemes = Physics2D.OverlapCircleAll(attackpoint.position,attackrange, enemylayers);
        
        foreach (Collider2D enemy in hitenemes)
        {
            enemy.GetComponent<enemy>().takedamge(attackdamge);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackpoint == null)
            return;
        Gizmos.DrawSphere(attackpoint.position, attackrange);
    }

}
