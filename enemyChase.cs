using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player;  // Drag the player GameObject here in the Inspector
    public float speed = 3f;

    void Update()
    {
        if (player != null)
        {
            // Move towards the player
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

            // Rotate to face the player
            Vector3 direction = (player.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        }
    }
}

