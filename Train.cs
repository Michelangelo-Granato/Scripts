using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train
{
    public List<TrainCar> TrainCars;
    

    public int size = 1;
    public int speed = 0;

    public Train(int speed,int size)
    {
        this.speed = speed;
        this.size = size;
    }


    //TRAIN CARS
    private int AddCar(TrainCar car)
    {
        TrainCars.Add(car);
      
        return GetSize();
    }
    private bool RemoveCar(int index)
    {
        if (GetSize() > 1 && (index > 1 && index < GetSize()-1)) {
            TrainCars.RemoveAt(index);
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
    /*private void SetFuel(int fuel)
    {
        this.fuel = fuel;
    }
    public int GetFuel()
    {
        return this.fuel;
    }*/


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}