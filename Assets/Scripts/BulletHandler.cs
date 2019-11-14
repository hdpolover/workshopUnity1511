using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHandler : MonoBehaviour
{
    public GameObject ExplosionParticle;
    
    private void OnTriggerEnter(Collider other)
    {
        GameObject explosion =  Instantiate(ExplosionParticle, gameObject.transform.position, gameObject.transform.rotation) as GameObject;

        Destroy(explosion, 1.5f);
    }
}
