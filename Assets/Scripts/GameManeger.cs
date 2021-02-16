using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{ 
    private static GameManeger _instacia;
    public static GameManeger instancia //singleton
    {
        get 
        {
            if (_instacia == null)
            {
                _instacia = FindObjectOfType<GameManeger>();
            }
            return _instacia;
        }
    }
    [SerializeField] List<Player> players;
    public int qualTurno = 0;
    private void Awake()
    {
        //garante que só existe uma instancia em todas as cenas. 
        if (instancia != this && instancia != null) 
        {
            Destroy(this.gameObject);
            return;
            
        }
        DontDestroyOnLoad(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        Player[] player = FindObjectsOfType<Player>();
        players.AddRange(player);
        qualTurno = 0;
        players[qualTurno % players.Count].turno = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PassarTurno()
    {
        players[qualTurno % players.Count].turno = false;
        qualTurno++;
        players[qualTurno %players.Count].turno = true;
    }
}
