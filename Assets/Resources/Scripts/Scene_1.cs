using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Scene_1 : MonoBehaviour,IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData){
    	GetComponent<Image>().color= new Color(1f,0.4f,0.4f,0.5f);
    	SceneManager.LoadScene("Scene_1");
    } 
}
