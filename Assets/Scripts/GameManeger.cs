using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    private static GameManeger _instacia;
    public static GameManeger instancia 
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
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
