using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple_Crates : MonoBehaviour, IInteractable
{


    void IInteractable.Interact(Transform interactorTransform)
    {
        Inventory_Manager.instance.addApple();
        
    }

    string IInteractable.GetInteractText()
    {
        return "Manzana";
    }

    Transform IInteractable.GetTransform()
    {
        return transform;
    }
}

