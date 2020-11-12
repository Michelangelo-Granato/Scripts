using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    public LinkedList<TrainCar> TrainCars = new LinkedList<TrainCar>();
     List<Character> CharList = new List<Character>();

    public int size = 1;
    public int speed = 0;
    public int fuel = 100;

    public Train()
    {

    }

    //TRAIN CARS
    private int AddCar(TrainCar train)
    {
        TrainCars.AddLast(train);
 

        return GetSize();
    }
    private bool RemoveCar(int index)
    {
        if (GetSize() > 1 && (index > 1 && index < GetSize()-1)) {
            TrainCars.RemoveLast();
            return true;
        } 
       
        return false;
    }
    //CHARACTERS

    //SIZE
    public int GetSize()
    {
        size = TrainCars.Count;
        return size;
    }
    //SPEED
    private void SetSpeed(int speed)
    {
        this.speed = speed;
    }
    public int GetSpeed()
    {
        return this.speed;
    }
    //FUEL
    private void SetFuel(int fuel)
    {
        this.fuel = fuel;
    }
    public int GetFuel()
    {
        return this.fuel;
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