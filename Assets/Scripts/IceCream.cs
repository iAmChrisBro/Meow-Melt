using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCream : MonoBehaviour
{
    [SerializeField]
    private string flavorType;
    [SerializeField]
    private string coneType;
    [SerializeField]
    private string typeOfIcecream;

    public string GetFlavor()
    { return flavorType; }

    public string GetConeType() 
    { return coneType;   }

    public string GetTypeOfIcecream()
    { return typeOfIcecream; }


}
