using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{
    

    [SerializeField] private Transform player;
    [SerializeField] private float ahddis;
    [SerializeField] private float camspeed;
    private float lookahd;
    
    


    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector3(player.position.x + lookahd, transform.position.y, transform.position.z);
        lookahd = Mathf.Lerp(lookahd, (ahddis * player.localScale.x), Time.deltaTime * camspeed);
    }

    
}
