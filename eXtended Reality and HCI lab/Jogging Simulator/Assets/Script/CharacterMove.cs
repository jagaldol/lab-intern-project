using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

    private Animator animator;
    private int isRunningHash;

    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();

        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        float xMove = Input.GetAxis("Horizontal");
        float zMove = 0.01f;
        bool rotateLeft = Input.GetKey("q");
        bool rotateRight = Input.GetKey("e");

        bool isRunning = animator.GetBool("isRunning");

        if (!isRunning && forwardPressed)
        {
            animator.SetBool(isRunningHash, true);
        }
        else if (isRunning && forwardPressed)
        {
            zMove = 0.3f;
            xMove *= 0.2f;

            transform.Translate(new Vector4(xMove, 0, zMove) * 20f * Time.deltaTime);
        }

        if (isRunning && !forwardPressed)
        {
            animator.SetBool(isRunningHash, false);
        }
        if (rotateLeft)
        {
            transform.Rotate(new Vector3(0, -30f, 0) * Time.deltaTime);
        }
        if (rotateRight)
        {
            transform.Rotate(new Vector3(0, 30f, 0) * Time.deltaTime);
        }
    }
}
