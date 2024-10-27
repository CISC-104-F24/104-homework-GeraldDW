using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeWork2 : MonoBehaviour

{
public float moveSpeed = 5.0f;
public Vector3 movementDirection = new Vector3(1f,0f,0f);
public float jumpPower = 5.0f;

 public float rotationSpeed = 100f;
 

 // Start is called before the first frame update
 void Start()
  {
      
  }

    // Update is called once per frame
    void Update()
    { 
       
    movementDirection = new Vector3 (0,0,0);
    
    if (Input.GetKey(KeyCode.W)) movementDirection += Vector3.forward;
if (Input.GetKey(KeyCode.D)) movementDirection += Vector3.right;
if (Input.GetKey(KeyCode.A)) movementDirection += Vector3.left;
if (Input.GetKey(KeyCode.S)) movementDirection += new Vector3 (0,0,-1);

if (Input.GetKeyDown(KeyCode.Space)) 
   {
    Rigidbody myRigidbody = GetComponent<Rigidbody>();
 myRigidbody.AddForce(new Vector3(0,1,0) * jumpPower);
   Debug.Log("In Air"); // Print "In Air" when jumping
   } 
 
 if (Input.GetKey(KeyCode.Q))
 {
   transform.Rotate(new Vector3(0,5,0) * rotationSpeed * Time.deltaTime);
   transform.Translate(movementDirection * moveSpeed * Time.deltaTime);
 }
 if (Input.GetKey(KeyCode.E))
 { transform.Rotate(new Vector3(0,-5,0) * rotationSpeed * Time.deltaTime);}
//movementDirection = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
transform.Translate(movementDirection * moveSpeed * Time.deltaTime);



    }
    
 }
