using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyBlock : MonoBehaviour
{
  public UnityEvent getBulletevent;

  private void OnCollisionEnter2D(Collision2D col)
  {
      if(col.gameObject.GetComponent<Projectile>())
          getBulletevent?.Invoke();
  }
}
