using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject disable;
    [SerializeField]
    private GameObject enable;
    private void OnMouseDown()
    {
        disable.SetActive(false);
        enable.SetActive(true);
    }
}
