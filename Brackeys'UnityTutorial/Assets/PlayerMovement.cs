using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rd;

	// Update is called once per frame
	void FixedUpdate ()
    {
        rd.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}