
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _puntosVida = 100;
    [SerializeField] private int _vidaMaxima = 100;
    [SerializeField] private UIManager _uiManager;
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

    private void Update()
    {
        if (_puntosVida >= 80)
        {
            _uiManager.ColorBarra(Color.green);
        }

        if ((40 <= _puntosVida) && (40 < 80)) 
        {
            _uiManager.ColorBarra(new Color(1f, 1f, 1f, 1f));

        }

        if (_puntosVida < 40)
        {
            _uiManager.ColorBarra(Color.red);
        }
    }


}
