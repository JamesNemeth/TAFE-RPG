using UnityEngine;

namespace RPG.Player
{
    [AddComponentMenu("RPG/Player/Movement")]
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Speed Vars")]
        //Value Variables
        public float moveSpeed;
        public float walkSpeed, runSpeed, crouchSpeed, jumpSpeed;
        private float _gravity = 20;
        //Struct Variable - Contains multiple variables (eg Transform... 3 floats)
        private Vector3 _moveDir;
        //Reference Variable
        private CharacterController _charC;

        private void Start()
        {
            // _charC gets the Character Controller from the object the script is on
            _charC = GetComponent<CharacterController>();
        }
        private void Update()
        {
            Move();
        }
        private void Move()
        {
            // if the player is alive
            if (!PlayerHandler.isDead)
            {
                // and is on the game
                if (_charC.isGrounded)
                {
                    //set speed to sprint when the sprint button is pressed
                    if (Input.GetButton("Sprint"))
                    {
                        moveSpeed = runSpeed;
                    }
                    //or set speed to sprint when the Crouch button is pressed
                    else if (Input.GetButton("Crouch"))
                    {
                        moveSpeed = crouchSpeed;
                    }
                    // if nothing is pressed, set to walk speed
                    else
                    {
                        moveSpeed = walkSpeed;
                    }

                    //calculates movements based on inputs
                    // allows the player to walk in any direction at walk speed
                    _moveDir = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed);
                    if (Input.GetButton("Jump"))
                    {
                        // if jump is pressed, move on the y axis at the speed allocated to jump speed
                        _moveDir.y = jumpSpeed;
                    }
                }
                if (PlayerHandler.isDead)
                {
                    // if you are dead, you wont be able to move
                   _moveDir = Vector3.zero;
                }
            }
            // allows the player to fall back to the ground
            _moveDir.y -= _gravity * Time.deltaTime;
            // player moves in real time
            _charC.Move(_moveDir * Time.deltaTime);
        }
    }
}