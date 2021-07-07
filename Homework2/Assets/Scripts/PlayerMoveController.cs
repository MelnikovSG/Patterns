using UnityEngine;

namespace Asteroids
{
    public class PlayerMoveController : Player
    {
        internal void Move()
        {
            _trusting = (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow));

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                _turnDirection = 1.0f;
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                _turnDirection = -1.0f;
            }
            else
            {
                _turnDirection = 0.0f;
            }
        }

        internal void FixMove()
        {
            if (_trusting)
            {
                pRigidbody.AddForce(this.transform.up * this.trustSpeed);
            }

            if (_turnDirection != 0.0f)
            {
                pRigidbody.AddTorque(_turnDirection * this.turnSpeed);
            }
        }
    }
}
