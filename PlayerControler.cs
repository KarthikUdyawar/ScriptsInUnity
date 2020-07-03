using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    private string MoveInputAxis = "Vertical";
    private string TurnInputAxis = "Horizontal";
    private string JinkInputAxis = "Jink";

    // rotation that occurs in angles per second holding down input
    public float rotationRate = 360;

    // units moved per second holding down move input
    public float moveRate = 10;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        float moveAxisZ = Input.GetAxis(MoveInputAxis);
        float moveAxisX = Input.GetAxis(JinkInputAxis);
        float turnAxis = Input.GetAxis(TurnInputAxis);

        ApplyInput(moveAxisZ, moveAxisX, turnAxis);
    }

    private void ApplyInput(float moveInputZ, float moveInputX, float turnInput)
    {
        Move(moveInputZ, moveInputX);
        Turn(turnInput);
    }

    private void Move(float inputZ, float inputX)
    {
        // Make sure to set drag high so the sliding effect is very minimal (5 drag is acceptable for now)

        // mention this trash function automatically converts to local space
        rb.AddForce(transform.forward * inputZ * moveRate, ForceMode.Force);
        rb.AddForce(transform.right * inputX * moveRate, ForceMode.Force);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }
         
}
s
