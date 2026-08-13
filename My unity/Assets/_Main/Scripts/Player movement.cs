using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField] private float _force = 5f;
    [SerializeField] private float _speed = 5f;

  
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
                _rigidbody2D.AddForce(Vector2.up * _force,ForceMode2D.Force);
                Debug.Log("Oprimi la tecla");
            }
            _rigidbody2D.velocity = Vector2.right * _speed;
        }

    }
    private void Update()
    {
        
    }
}
   
