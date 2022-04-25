using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    Vector2 move;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       // rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.Translate(move * runSpeed * Time.deltaTime);
       
    }
}
