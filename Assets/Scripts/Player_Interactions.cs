using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class Player_Interactions : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){

            IInteractable interactable = getInteractable();

            if (interactable != null)
            {
                interactable.Interact(transform);
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Application.Quit();
        }

    }

    public IInteractable getInteractable()
    {
        List<IInteractable> InteractableList = new List<IInteractable>();

        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange, 000000000000000000000000001000000);
        IInteractable closestInteractable = null;

        foreach (Collider collider in colliderArray)
        {

            if (collider.TryGetComponent(out IInteractable interactable))
            {
                InteractableList.Add(interactable);
            }
        }

        foreach (IInteractable interactable in InteractableList) { 
            if (closestInteractable == null)
            {
                closestInteractable = interactable;
            }
            else
            {

                if (Vector3.Distance(transform.position, interactable.GetTransform().position) <
                    Vector3.Distance(transform.position, closestInteractable.GetTransform().position))
                {
                    closestInteractable = interactable;
                }
            }

        }
        return closestInteractable;
    }

}
