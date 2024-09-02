using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody2D character;

    [SerializeField] 
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    [Range(1f, 10f)]
    private float characterSpeed = 5f;

    [SerializeField]
    private Animator animator;

    private float characterMoveX;
    private float characterMoveY;
    private Vector2 characterDirection;


    private void Move()
    {

        characterMoveX = Input.GetAxis("Horizontal");
        characterMoveY = Input.GetAxis("Vertical");
        characterDirection = new Vector2(characterMoveX, characterMoveY).normalized;
        character.MovePosition(character.position + (characterDirection * characterSpeed * Time.deltaTime));
        spriteRenderer.flipX = Math.Sign(Input.GetAxis("Horizontal")) < 0;

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        ControlAnim();
    }

    private void ControlAnim()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            animator.SetBool("running", true);
            return;
        }

        animator.SetBool("running", false);
    }

}
