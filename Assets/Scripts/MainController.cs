using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    private List<Animal> _animals = new();

    // Start is called before the first frame update
    void Start()
    {
        var dog = new Dog
        {
            Name = "Doggy",
            IsGoodBoy = true
        };

        _animals.Add(dog);

        var cat = new Cat
        {
            Name = "Kitty"
        };

        _animals.Add(cat);
    }

    public void LogStuff()
    {
        foreach (var animal in _animals)
        {
            animal.GetDetails();
            animal.Move();
        }
    }
}
