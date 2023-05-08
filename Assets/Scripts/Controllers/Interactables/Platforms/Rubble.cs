using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interfaces.Hittable;

public class Rubble : MonoBehaviour, IHittable
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnHit(collision.gameObject);
    }
    public void OnHit(GameObject other)
    {
        if (other.tag is "Explosive")
        {
            Destroy(gameObject);
        }
    }
}
