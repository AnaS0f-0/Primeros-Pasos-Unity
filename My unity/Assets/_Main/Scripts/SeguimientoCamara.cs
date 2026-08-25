using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    [SerializeField] private Transform _objetivo;
   


    private void Update()
    {
        transform.position = new Vector3(_objetivo.position.x, this._objetivo.position.y, this.transform.position.z);
            
            
          


    }
}
