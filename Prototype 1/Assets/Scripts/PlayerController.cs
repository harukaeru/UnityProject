using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private float speed = 15.0f;
  private float turnSpeed = 25.0f;
  private float verticalInput;
  private float horizontalInput;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    verticalInput = Input.GetAxis("Vertical");
    horizontalInput = Input.GetAxis("Horizontal");

    transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
  }
}
