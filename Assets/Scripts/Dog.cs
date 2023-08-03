using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    public bool IsGoodBoy { get; set; }

    // POLYMORPHISM
    public override void GetDetails()
    {
        var attribute = IsGoodBoy ? "good" : "bad";
        Debug.Log($"My name is {Name} an i'm a {attribute} boy");
    }

    public override void Move()
    {
        // ABSTRACTION
        MoveLeftBackLeg();
        MoveLeftFrontLeg();
        MoveRightFrontLeg();
        MoveRightBackLeg();
    }

    private void MoveLeftFrontLeg()
    {
        Debug.Log("Incredible complex stuff to move the left front leg");
    }

    private void MoveRightFrontLeg()
    {
        Debug.Log("Incredible complex stuff to move the right front leg");
    }

    private void MoveLeftBackLeg()
    {
        Debug.Log("Incredible complex stuff to move the left back leg");
    }

    private void MoveRightBackLeg()
    {
        Debug.Log("Incredible complex stuff to move the right back leg");
    }
}
