using UnityEngine;


namespace Asteroids
{
    public class BulletController : Bullet
    {
        public void Project(Vector2 direction)
        {
            bRigibody.AddForce(direction * this.speed);
            Destroy(this.gameObject, this.maxLifeTime);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(this.gameObject);
        }
    }
}
