
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField] private float _fuerzaSalto = 5f;
    [SerializeField] private float _velocidadMovimiento = 5f;

    [SerializeField] private Rigidbody2D _cuerpoRigido2D;
    [SerializeField] private DetectorSuello _detectorSuelo;

    public float 
VelocidadMovimiento { get => _velocidadMovimiento; set => _velocidadMovimiento = value; }


    private void Awake()
    {
        _cuerpoRigido2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (_detectorSuelo.estaEnSuelo)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _cuerpoRigido2D.AddForce(Vector2.up * _fuerzaSalto, ForceMode2D.Impulse);
                 
                   
              

                Debug.Log("Oprimí la tecla");
            }
        }

        _cuerpoRigido2D.velocity = new Vector2(1 * VelocidadMovimiento, _cuerpoRigido2D.velocity.y);
          
            
     
    }
}
