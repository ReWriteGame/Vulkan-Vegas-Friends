using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    public UnityEvent brekeEvent;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.GetComponent<Projectile>())
            brekeEvent?.Invoke();
    }
}
