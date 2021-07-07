using UnityEngine;



namespace Asteroids
{
    public class PlayerController : MonoBehaviour
    {
        PlayerMoveController playerMove = new PlayerMoveController();
        PlayerShootController playerShoot = new PlayerShootController();
        private void Update()
        {
            playerMove.Move();
            playerShoot.Shoot();
        }

        private void FixedUpdate()
        {
            playerMove.FixMove();
        }
    }
}
