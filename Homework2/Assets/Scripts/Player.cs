using UnityEngine;


namespace Asteroids
{
    public class Player : MonoBehaviour
    {

        public Bullet bulletPrefab;
        public float trustSpeed = 1.0f;
        public float turnSpeed = 1.0f;

        internal Rigidbody2D pRigidbody;
        internal bool _trusting;
        internal float _turnDirection;

        private void Awake()
        {
           pRigidbody = GetComponent<Rigidbody2D>();
        }
    }
}
