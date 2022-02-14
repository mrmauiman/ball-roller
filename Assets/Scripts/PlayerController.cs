using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 input = Vector2.zero;
    Rigidbody rb;
    public static float speed = 500f;

    void getInput()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");
    }

    void movePlayer()
    {
        Vector3 force = new Vector3(input.x, 0, input.y);
        force *= speed * Time.deltaTime;
        rb.AddForce(force, ForceMode.Force);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        getInput();

        movePlayer();
    }
}
