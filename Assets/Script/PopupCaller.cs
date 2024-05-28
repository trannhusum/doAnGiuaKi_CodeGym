using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupCaller : MonoBehaviour
{
    [SerializeField] private GameObject container;
    [SerializeField] private GameObject butoons;
    public void Open()
    {
        container.SetActive(true);
        butoons.SetActive(false);
    }

    public void Close()
    {
        container.SetActive(false);
        butoons.SetActive(true);
    }
}
