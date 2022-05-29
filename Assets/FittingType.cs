using Assets.Presenter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FittingType : MonoBehaviour
{
    [SerializeField]
    private FittingTypes fittingType;
    public FittingTypes TypeOfFitting
    {
        get { return fittingType; }
        private set { fittingType = value; }
    }
}
