using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    private bool isDisable = true;
    [SerializeField]
    private GameObject gameObject;
    private void OnMouseDown()
    {
        if(isDisable == true)
        {
            gameObject.SetActive(true);
            isDisable = false;
        }else
        {
            gameObject.SetActive(false);
            isDisable = true;
        }
    }
}
