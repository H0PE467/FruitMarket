using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange_Crates : MonoBehaviour, IInteractable
{


    void IInteractable.Interact(Transform interactorTransform)
    {
        Inventory_Manager.instance.addOrange();

    }

    string IInteractable.GetInteractText()
    {
        return "Naranja";
    }

    Transform IInteractable.GetTransform()
    {
        return transform;
    }
}