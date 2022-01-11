using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem MuzzleFlash;

	void Update () {
		
        if(Input.GetButtonDown("Fire"))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        MuzzleFlash.Play();


        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
