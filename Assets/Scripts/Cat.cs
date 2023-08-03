using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cat : Animal
{
    public override void Move()
    {
        Debug.Log($"{Name} don't want to move");
    }
}
