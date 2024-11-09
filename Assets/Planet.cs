using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private GameObject planet;
    private Rigidbody2D rb;
    [SerializeField] private float gravityForce;
    [SerializeField] private float gravityDistance;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float distance = Vector2.Distance(planet.transform.position, transform.position);
        Vector2 v = planet.transform.position - transform.position;

        rb.AddForce(v.normalized * (gravityForce - distance / gravityDistance));
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(planet.transform.position, gravityDistance);
    }
}
