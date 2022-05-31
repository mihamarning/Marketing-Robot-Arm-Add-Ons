using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    [SerializeField]
    private GameObject fittingPosition;

    [SerializeField]
    private GameObject fitting;


    void Start()
    {
        fitting.transform.position = fittingPosition.transform.position;
        fitting.transform.rotation = fittingPosition.transform.rotation;
    }

    
}
