using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuTab : MonoBehaviour
{
    EventSystem system;

    private void Start()
    {
        system = EventSystem.current;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Selectable nextItem = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
         
            if (nextItem != null)
            {
             
                InputField nextInputField = nextItem.GetComponent<InputField>();
                if (nextInputField != null)
                    nextInputField.OnPointerClick(new PointerEventData(system)); 
             
                system.SetSelectedGameObject(nextItem.gameObject, new BaseEventData(system));
            }
         
        }
    }
}
