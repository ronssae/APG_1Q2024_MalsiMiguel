using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarWars : MonoBehaviour
{
    [SerializeField] private List<Rigidbody> autoRb;
    [SerializeField] private List<Rigidbody> manualRb;
    [SerializeField] private float force;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for (int i = 0; i < autoRb.Count; i++)
        {
            autoRb[i].AddForce(transform.up * force, i switch
            {
                0 => ForceMode.Force,
                1 => ForceMode.Impulse,
                2 => ForceMode.Acceleration,
                3 => ForceMode.VelocityChange,
                _ => ForceMode.Force
            });
        }

        for (int i = 0; i < manualRb.Count; i++)
        {
            manualRb[i].velocity += i switch
            {
                0 => new Vector3(0, force * Time.deltaTime / manualRb[i].mass),
                1 => new Vector3(0, force / manualRb[i].mass),
                2 => new Vector3(0, force * Time.deltaTime),
                3 => new Vector3(0, force),
                _ => Vector3.zero
            };
        }
    }
}
