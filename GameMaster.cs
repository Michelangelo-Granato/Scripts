using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster GM { get; private set; }

    public int fuel;
    public int water;
    public Train train = new Train(1,1);



    // Start is called before the first frame update
    void Start()
    {
        //GOTTA INITIATE STUFF I GUESS

    }

    // Update is called once per frame
    void Update()
{
        
    }
    private void Awake()
    {
        if (GM != null)
        {
            GameObject.Destroy(GM);
        }
        else
        {
            GM = this;
        }
        DontDestroyOnLoad(this);
    }
}
