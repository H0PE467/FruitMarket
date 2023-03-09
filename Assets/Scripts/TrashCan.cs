using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour, IInteractable
{


    void IInteractable.Interact(Transform interactorTransform)
    {
        Inventory_Manager.instance.emptyInventory();

    }

    string IInteractable.GetInteractText()
    {
        return "Vaciar Inventario";
    }

    Transform IInteractable.GetTransform()
    {
        return transform;
    }
}
