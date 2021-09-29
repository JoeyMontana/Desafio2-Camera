using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

   public CharacterController controller;

   public float speed = 12f;
   void Update() {
        float x = Input.GetAxis("Horizontal");

        Vector3 move = transform.right * x;

        controller.Move(move * speed * Time.deltaTime);
   }
}
