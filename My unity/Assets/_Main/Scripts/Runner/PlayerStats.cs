
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    [SerializeField] private int _vidaMaxima = 100; 
    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;



    }

    public void SumarVida(int daño)
    {
        _puntosVida = _puntosVida + daño;

        if (_puntosVida > _vidaMaxima)
        {
            _puntosVida = _vidaMaxima;
        }
    }


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
