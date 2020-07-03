using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateTowards : MonoBehaviour
{
    [SerializeField]
    Transform transTowards;

    [SerializeField]
    float fSpeed;

    Rigidbody rigid;

    void Start()
    {
         rigid = GetComponent<Rigidbody>();
         if (transTowards == null)
         {
               transTowards = FindObjectOfTyoe<AddPlayerControlledVelocity>().transform;
    }

    void Update()
    {
         Vector3 v3MeTowardsTarget = transTowards.position - Transform.position
         rigid.velocity += v3MeTowardsTarget.normalized * fSpeed * Time.deltaTime;
