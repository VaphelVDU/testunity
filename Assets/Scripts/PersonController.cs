using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonController : MonoBehaviour
{
    public Person person;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            person.PrintInfo();
        }
    }
}
