using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Completed
{

    public class PlayerMovement : MonoBehaviour
    {
        [Tooltip("The speed of the player")]
        public float speed = 5.0f;

        [Tooltip("The max speed the player can go")]
        public float MaxSpeed = 15.0f;

        private Rigidbody _rb;
        private float _horizontalInputValue, _verticalInputValue;

        void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            // Get the input from the user
            _horizontalInputValue = Input.GetAxis("Horizontal");
            _verticalInputValue = Input.GetAxis("Vertical");
        }

        private void FixedUpdate()
        {
            MoveWithWorld();
        }


        private void MoveWithWorld()
        {
            Vector3 movement =
                new Vector3(
                    _horizontalInputValue * speed,
                    0f,
                    _verticalInputValue * speed
                    );

            // Doing movement this way is how I have found it to feel best, but maybe a little floaty. Uses mass
            _rb.AddForce(movement, ForceMode.Impulse);

            // Clamp speed
            if (_rb.velocity.magnitude > MaxSpeed)
            {
                _rb.AddForce(-(_rb.velocity) * (_rb.velocity.magnitude - MaxSpeed));
            }
        }


    }




}
