using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControleDaUi : MonoBehaviour
{
    public Text pontosDeVidaPlayer1;
    public Text pontosDeVidaPlayer2;
    public Text turno;
    public Player player1;
    public Player player2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turno.text = "Turno: " + GameManeger.instancia.qualTurno.ToString();
        pontosDeVidaPlayer1.text = "Pontos de vida do player 1: " + player1.pontosDeVida;
        pontosDeVidaPlayer2.text = "Pontos de vida do player 2: " + player2.pontosDeVida;
    }
}
