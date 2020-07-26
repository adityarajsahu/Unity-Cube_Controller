using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{	
	public Rigidbody rb;
	public float frontForce = 1000f;
	public float sideForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
     	  
    }

    // Update is called once per frame
    void Update()
    {
     	if (Input.GetKey("w"))
     	{
     		rb.AddForce(0, 0, frontForce * Time.deltaTime);
     	}
     	if (Input.GetKey("s"))
     	{
     		rb.AddForce(0, 0, -(frontForce * Time.deltaTime));
     	}
     	if (Input.GetKey("a"))
     	{
     		rb.AddForce(-(sideForce * Time.deltaTime), 0, 0);
     	}
     	if (Input.GetKey("d"))
     	{
     		rb.AddForce(sideForce * Time.deltaTime, 0, 0);
     	}  
    }
}
