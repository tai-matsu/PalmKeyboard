using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharInput : MonoBehaviour
{
    TMP_InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        inputField = this.GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        inputField.text = "あ";
    }
}
