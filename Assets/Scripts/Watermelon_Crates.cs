using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon_Crates : MonoBehaviour, IInteractable
{


    void IInteractable.Interact(Transform interactorTransform)
    {
        Inventory_Manager.instance.addWatermelon();

    }

    string IInteractable.GetInteractText()
    {
        return "Sand�a";
    }

    Transform IInteractable.GetTransform()
    {
        return transform;
    }
}