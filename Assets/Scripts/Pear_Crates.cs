using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pear_Crates : MonoBehaviour, IInteractable
{


    void IInteractable.Interact(Transform interactorTransform)
    {
        Inventory_Manager.instance.addPear();

    }

    string IInteractable.GetInteractText()
    {
        return "Pera";
    }

    Transform IInteractable.GetTransform()
    {
        return transform;
    }
}

