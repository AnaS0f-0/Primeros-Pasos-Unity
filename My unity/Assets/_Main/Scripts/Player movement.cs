using UnityEngine;

public class Playermovement : MonoBehaviour



{
    // Variables


    [SerializeField] private int _edad = 17;

    
    public float fuerza = 500f;
    
   

   

    [SerializeField] private Rigidbody2D _rigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D.AddForce(Vector2.right * fuerza);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
