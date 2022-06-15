using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Create a custom button
public class KeyboardButton : Button
{
    private TMP_InputField m_inputfield;

    protected override void Start()
    {
        base.Start();

        m_inputfield = GameObject.Find("EntryField").GetComponent<TMP_InputField>();

        Button button = GetComponent<Button>();

        //Create custom event listeners

        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(AddInput);
    }


    private void AddInput()
    {
        //Add letter to value after every keystroke
        string letter = gameObject.name;
        
        m_inputfield.text += letter;
        
    }

}
