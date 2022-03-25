using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Projectile : MonoBehaviour
{
    public UnityEvent getBlockEvent; 
    public UnityEvent getBasaEvent; 
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.GetComponent<DestroyBlock>())
            getBasaEvent?.Invoke();
        
        if(col.gameObject.GetComponent<Block>())
            getBlockEvent?.Invoke();
    }
}
