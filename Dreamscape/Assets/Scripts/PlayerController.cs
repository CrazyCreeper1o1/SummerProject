using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public int i;


    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed * Input.GetAxis("Horizontal") * Time.deltaTime, transform.position.y);
        bool jump = Input.GetButtonDown("Jump");
        //Debug.Log("Jump: " + Input.GetButtonDown("Jump"));
        if (jump)
        {
            Debug.Log("Jumped " + i + " times!  Input.GetButtonDown(\"Jump\") is returning " + jump);
            i++;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpSpeed);
        }
    }
}
