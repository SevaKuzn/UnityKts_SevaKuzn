using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Purchasing.Security;

public class Enemy : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private float damage = 1f;
    private bool isAttack = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            isAttack = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && isAttack)
        {
            player.hp -= damage;
        }
    }
}
