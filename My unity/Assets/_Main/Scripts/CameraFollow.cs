
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        this.transform.position = new Vector3(_target.position.x,this._target.position.y,this.transform.position.z);
    }


}
