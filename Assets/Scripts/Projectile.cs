using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody projectile;
    public GameObject clone;
    //[SerializeField] Transform firingPoint;
    [SerializeField] float firingSpeed;

    private void Awake()
    {
        projectile = GetComponent<Rigidbody>();
        clone = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        projectile.AddForce(transform.forward * firingSpeed);

        if (Application.isEditor)
        {
            DestroyImmediate(clone);
        }
        else
        {
            Destroy(clone);
        }
    }
}
