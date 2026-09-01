using UnityEngine;

public class ObstaculoMortal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("player"))
        {

            _playerStats.RestarVida(10);
        }
    }
}

