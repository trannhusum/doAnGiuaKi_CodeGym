using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PopupCharacter : MonoBehaviour
{
    [SerializeField] private Sprite newImage;
    [SerializeField] private Image image;
    [SerializeField] private GameObject gameObject;
    public void Select()
    {
        image.sprite= newImage;
    }
    public void Unlock()
    {
        Destroy(gameObject);
    }

}
