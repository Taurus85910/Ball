using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDescription : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    public void OpenPanel() => _panel.SetActive(true);
}
