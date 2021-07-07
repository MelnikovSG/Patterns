using UnityEngine;


namespace Asteroids
{
    public class Bullet : Player
    {
        public float speed = 500.0f;
        public float maxLifeTime = 10.0f;
        internal Rigidbody2D bRigibody;
        private void Awake()
        {
            bRigibody = GetComponent<Rigidbody2D>();
        }

       
    }
}
