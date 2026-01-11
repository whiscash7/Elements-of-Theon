using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private CharacterController controller;
    [SerializeField] private SpriteRenderer sprite;

    public Vector3 move;
    public int speed = 10;
    public bool stopMoving = false;

    void Update()
    {
        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        move = Vector3.ClampMagnitude(move, 1f);

        // if they are moving, play running animation, otherwise play idle
        if (!stopMoving)
        {
            if (move != Vector3.zero)
            {
                animator.SetBool("isRunning", true);
            }
            else
            {
                animator.SetBool("isRunning", false);
            }

            // flip the sprite depending on which way they are going
            if (move.x < 0)
            {
                sprite.flipX = true;
            }
            else if (move.x > 0)
            {
                sprite.flipX = false;
            }

            controller.Move(move * Time.deltaTime * speed);
        }
    }
}
