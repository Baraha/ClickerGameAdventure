using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitreaction : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Debug.Log("OnMouseDown()");
        GetComponent<Animator>().SetTrigger("Hit");
        GetComponent<Health>().GetHit(10);

    }
}
