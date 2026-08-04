using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float altura = 1.53f;
    public int edad = 17;
    public string nombre = "Anny";
    public bool puedeVotar = true;

    public GameObject gameObject;
    public Rigidbody2D rigidbody2D;
    public Collider2D collider2D;
    public SpriteRenderer spriteRenderer;
    public Transform transform;

    private void Start()
    {
        Debug.Log(" Hola: " + nombre + " tu edad es: " + edad + " tu altura es: " + altura);
        rigidbody2D.simulated = false;
        spriteRenderer.color = Color.magenta;
        transform.position = new Vector3(10f, 0f, 0f);
    }

    private void Update()
    {

    }
}
   
