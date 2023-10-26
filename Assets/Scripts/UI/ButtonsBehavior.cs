using System;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public TMP_InputField hoursInput;
    public TMP_InputField minutesInput;
    public TMP_Dropdown porcaoDropdown;

    public void SendHorario()
    {
        int hours = int.Parse(hoursInput.text);
        int minutes = int.Parse(minutesInput.text);
        string dateString = $"{hours:D2}:{minutes:D2}:00";

        string filePath = Path.Combine(Application.persistentDataPath, "savedDate.txt");

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        File.WriteAllText(filePath, dateString);

        string porcao = porcaoDropdown.options[porcaoDropdown.value].text;

        filePath = Path.Combine(Application.persistentDataPath, "savedPorcao.txt");

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        File.WriteAllText(filePath, porcao);
    }

    public void SaveTextToFile()
    {
        
    }

    public void OpenAboutUs()
    {
        string aboutUs = "https://github.com/master0022/PetMenu/";
        Application.OpenURL(aboutUs);
    }

    public void OpenLoginPage()
    {
        string loginpage = "https://secure.login.gov/";
        Application.OpenURL(loginpage);
    }
}
