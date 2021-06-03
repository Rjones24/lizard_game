  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private CharacterController controller;

    private Vector3 velocity;
    public float gravity = 9.81f;
    public float JumpHight = 3.0f;
    public LayerMask groundMask;
    bool Grounded;

    public GameObject Tongue;
    public GameObject punchTounge;
    public Transform Spawn;
    public GameObject sound;
    public float fireTime = 0.5f;
    private bool isFiring = false;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Grounded = controller.isGrounded;

        float Horizintal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");
        bool Sprint = Input.GetButton("Sprint");
        bool Jump = Input.GetButton("Jump");
        float LookHorizontal = Input.GetAxisRaw("Controller X");

        if (!isFiring)
        {
            if (Input.GetAxisRaw("Fire1") > 0)
            {
                sticky();
            }
            else if (Input.GetAxisRaw("Fire2") > 0)
            {
                Punch();
            }

            transform.Rotate(0f, LookHorizontal, 0f, Space.Self);

            if (Input.GetButtonDown("Jump") && Grounded)
            {
                velocity.y = Mathf.Sqrt(JumpHight * 2.0f * gravity);
            }
            else if (Grounded)
            {
            }

            velocity.y += -gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);

            if (Sprint)
            {
                SprintMech(Horizintal, Vertical);
            }
            else
            {
                MoveMech(Horizintal, Vertical);
            }
        }
    }

    private void SetFiring()
    {
        isFiring = false;
    }

    private void Punch()
    {
        isFiring = true;
        sound.GetComponent<AudioSource>().Play();
        Instantiate(punchTounge, Spawn.position, Spawn.rotation);

        Invoke("SetFiring", fireTime);
    }
    private void sticky()
    {
        isFiring = true;
        sound.GetComponent<AudioSource>().Play();
        Instantiate(Tongue, Spawn.position, Spawn.rotation);

        Invoke("SetFiring", fireTime);
    }


    void SprintMech(float Horizintal, float Vertical)
    {
        transform.Translate(Horizintal * 40 * Time.deltaTime , 0f, 0f);
        transform.Translate(0f, 0f, Vertical * 40 * Time.deltaTime );
    }

    void MoveMech(float Horizintal, float Vertical)
    {
        transform.Translate(Horizintal * 20 * Time.deltaTime , 0f, 0f);
        transform.Translate(0f, 0f, Vertical * 20 * Time.deltaTime);
    }
}
