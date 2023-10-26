using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HorarioAgendadoController : MonoBehaviour
{
    public TextMeshProUGUI horarioAgendado;
    public TextMeshProUGUI porcao;

    private float timer = 0.4f;
    private float currentTime = 0f;

    private void Start()
    {
        
    }

    private void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= timer)
        {
            currentTime = 0f;
            ReadAndDisplayText();
            ReadAndDisplayPortion();
        }
    }

    private void ReadAndDisplayText()
    {
        string filePath = Path.Combine(Application.persistentDataPath, "savedDate.txt");
        if (File.Exists(filePath))
        {
            string savedText = File.ReadAllText(filePath);
            horarioAgendado.text = savedText;
        }
        else
        {
            horarioAgendado.text = "Connection error.";
        }
    }

    private void ReadAndDisplayPortion()
    {
        string filePath = Path.Combine(Application.persistentDataPath, "savedPorcao.txt");
        if (File.Exists(filePath))
        {
            string savedText = File.ReadAllText(filePath);
            porcao.text = savedText;
        }
        else
        {
            porcao.text = "Connection error.";
        }
    }
}
