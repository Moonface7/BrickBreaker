using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallControl : MonoBehaviour
{
    public AudioClip soundEffect;
    public GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(soundEffect,transform.position);
        Vector3 pos = collision.contacts[0].point; // first point of impact
        GameObject go = Instantiate(hitEffect, pos, Quaternion.identity) as GameObject; 
        Destroy(go,1f);
    }
}
