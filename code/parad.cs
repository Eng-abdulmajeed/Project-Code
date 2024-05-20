using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parad : MonoBehaviour
{
  public Camera cam;

  public Transform subject;

    Vector2 startposition;
    //Vector2 parallaxFactor;
    float startZ;

    Vector2 travel => (Vector2)cam.transform.position - startposition ;
    
    float dfromsubject => transform.position.z - subject.position.z;

    float clippingplane => (cam.transform.position.z + (dfromsubject > 0 ? cam.farClipPlane : cam.nearClipPlane));

    float parallaxFactor => Mathf.Abs(dfromsubject) / clippingplane ;

    


    public void Start()
    {
        startposition = transform.position;
        startZ = transform.position.z;

    }
    public void Update()
    {
        Vector2 newposi = startposition + travel*parallaxFactor;
        transform.position = new Vector3 (newposi.x,newposi.y,startZ);
    }


}
