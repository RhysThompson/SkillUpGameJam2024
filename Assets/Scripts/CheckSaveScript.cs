using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSaveScript : MonoBehaviour
{
    public string SceneToCheck;
    void Start()
    {
        if(!PlayerPrefs.HasKey(SceneToCheck)) this.gameObject.GetComponent<UnityEngine.UI.Button>().interactable = false;
    }
}
