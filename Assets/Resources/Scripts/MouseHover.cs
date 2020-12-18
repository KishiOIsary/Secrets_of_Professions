using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MouseHover : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData){
    	GetComponent<Image>().color= new Color(0.4f,0.4f,0.4f,0.5f);
    } 

    public void OnPointerExit(PointerEventData eventData){
    	GetComponent<Image>().color= Color.clear;
    } 
}
