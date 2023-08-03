using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal
{
    private string _name;

    // ENCAPSULATION
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Debug.Log($"empty string is not allowed for {nameof(Name)}");
                return;
            }

            _name = value.Trim();
        }
    }

    public virtual void GetDetails()
    {
        Debug.Log($"My name is {_name}");
    }

    public abstract void Move();
}
