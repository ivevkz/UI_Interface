using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class ButtonEvents : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] private Image _image;
    private Animator _animator;
    
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _image.enabled = false;
    }    

    public void OnPointerEnter(PointerEventData eventData)
    {
        _animator.SetBool("AnimStart", true);
        _image.enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _animator.SetBool("AnimStart", false);
        _image.enabled = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Нажата кнопка " + eventData.selectedObject.name);
    }
}
