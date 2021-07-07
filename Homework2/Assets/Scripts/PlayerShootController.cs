using UnityEngine;


namespace Asteroids
{
    public class PlayerShootController : Player
    {
        BulletController bulletC = new BulletController();
        internal void Shoot()
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                Shooting();
            }
        }
        private void Shooting()
        {
            Bullet bullet = Instantiate(this.bulletPrefab, this.transform.position, this.transform.rotation);
            bulletC.Project(this.transform.up);
        }
    }
}
