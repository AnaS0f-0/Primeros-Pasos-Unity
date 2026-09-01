
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;

        // + suma
        // - resta
        // / division 
        // * multiplicacion

        // = asignar
        //== comparar
        // ! diferente
        // && y
        // || o

        // !=
        //-=
        //+=
        //++ sumar 1
        //-- restar 1
    }
}
