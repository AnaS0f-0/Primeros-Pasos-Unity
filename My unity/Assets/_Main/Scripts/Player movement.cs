using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField] private float _jumpforce = 5f;
    [SerializeField] private float _movementSpeed = 5f;

  
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private GroundCheck _groundCheck;
   
    private void Awake()
    {

        _rigidbody2D = GetComponent<Rigidbody2D>();
        
    }
    private void Start()
    {
        
    }
    private void FixedUpdate()

    {
        if (_groundCheck.isGround)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _rigidbody2D.AddForce(Vector2.up * _jumpforce, ForceMode2D.Impulse);// topo de fuerza Impulso
                Debug.Log("Oprimi la tecla");
            }
            _rigidbody2D.velocity = new Vector2(1 * _movementSpeed, _rigidbody2D.velocity.y);//Multiplicar solo por X
        }

    }
    private void Update()
    {
        
    }
}
   
