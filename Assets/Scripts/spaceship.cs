using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent (typeof(Rigidbody))]

public class spaceship : MonoBehaviour
{

    [Header("===Movement===")]
    [SerializeField]
    private float thrust = 50f;
    [SerializeField, Range(0.001f, 0.999f)]
    private float glideReduction = 0.111f;

    Rigidbody rb;
    private Vector2 movement;
    private float glide;


    [Header("===PlayerClass===")]
    public float health;

    private SpaceshipController controller;

    private void Awake()
    {
        controller = new SpaceshipController();

    }

    private void OnEnable()
    {
        controller.Enable();
        controller.Spaceship.Movement.started += Movement;
    }

    private void OnDisable()
    {
        controller.Disable();
        controller.Spaceship.Movement.canceled -= Movement;
    }



    void Start()
    {
        rb = GetComponent<Rigidbody>();
        health = 100f;
    }

    void Update()
    {
        //Vector2 move = controller.Spaceship.Movement.ReadValue<Vector2>();
        //Debug.Log(move);
        if (movement.magnitude != 0f)
        {
            rb.AddRelativeForce(new Vector3(movement.x, movement.y, 0) * thrust * Time.deltaTime);
        }
    }

    public void Movement(InputAction.CallbackContext context)
    {
        //Debug.Log(context.ReadValue<Vector2>());
        movement = context.ReadValue<Vector2>();

    }
}
