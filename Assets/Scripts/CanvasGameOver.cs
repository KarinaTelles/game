using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasGameOver : MonoBehaviour
{
    [SerializeField] Text whoWin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        whoWin.text ="O player " + GameManeger.instancia.playerQuePerdeu.ToString() + " perdeu";
    }
}
