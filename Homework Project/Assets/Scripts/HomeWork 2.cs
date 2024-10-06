using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeWork2 : MonoBehaviour

{
public float moveSpeed = 5.0f;
public Vector3 movementDirection = new Vector3(1f,0f,0f);
public float jumpPower = 5.0f;


 // Start is called before the first frame update
 void Start()
  {
      
  }

    // Update is called once per frame
    void Update()
    { 
        
{
    
    if (Input.GetKeyDown(KeyCode.W)) transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
if (Input.GetKeyDown(KeyCode.D)) transform.position += Vector3.right * moveSpeed * Time.deltaTime;
if (Input.GetKeyDown(KeyCode.A)) transform.position += Vector3.left * moveSpeed * Time.deltaTime;
if (Input.GetKeyDown(KeyCode.Space)) transform.position += Vector3.up * moveSpeed * Time.deltaTime;
if (Input.GetKeyDown(KeyCode.DownArrow)) transform.position += Vector3.down * moveSpeed * Time.deltaTime;
if (Input.GetKeyDown(KeyCode.S)) transform.position += new Vector3 (0,0,-1) * moveSpeed * Time.deltaTime;

movementDirection = movementDirection + Vector3.forward;
movementDirection = movementDirection + Vector3.right;
movementDirection = movementDirection + Vector3.left;
movementDirection = movementDirection + new Vector3 (0,0,-1);

movementDirection = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
transform.Translate(movementDirection * moveSpeed * Time.deltaTime);


    }
   
    }
 }