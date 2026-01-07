using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCutScene : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI plrRep;
    [SerializeField]private GameObject plrRepGO;
    [SerializeField]private GameObject enmRepGO;
    [SerializeField]private TextMeshProUGUI enmRep;
    private int diaPos = 0;
    private bool blockDia = false;
    void Start()
    {
        plrRepGO.SetActive(true);
        plrRep.text = "-Здарова мужик!";
        diaPos = 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && diaPos == 1 && blockDia == false)
        {
            plrRepGO.SetActive(false);
            enmRepGO.SetActive(true);
            enmRep.text = "Чё тебе надо?-";
            blockDia = true;
            diaPos = 2;
            Invoke("unlockDia", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && diaPos == 2 && blockDia == false)
        {
            enmRepGO.SetActive(false);
            plrRepGO.SetActive(true);
            plrRep.text = "-Да хотел спросить, как новый год праздновать будешь?";
            blockDia = true;
            diaPos = 3;
            Invoke("unlockDia", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && diaPos == 3 && blockDia == false)
        {
            plrRep.text = "-Хожу новогоднее настроение поднимаю всем.";
            blockDia = true;
            diaPos = 4;
            Invoke("unlockDia", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && diaPos == 4 && blockDia == false)
        {
            plrRepGO.SetActive(false);
            enmRepGO.SetActive(true);
            enmRep.text = "Никак.-";
            blockDia = true;
            diaPos = 5;
            Invoke("unlockDia", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && diaPos == 5 && blockDia == false)
        {
            enmRep.text = "Его не будет.-";
            blockDia = true;
            diaPos = 6;
            Invoke("unlockDia", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && diaPos == 6 && blockDia == false)
        {
            enmRep.text = "И даже не потому что дед Мороз принял Ислам.-";
            blockDia = true;
            diaPos = 7;
            Invoke("unlockDia", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && diaPos == 7 && blockDia == false)
        {
            enmRepGO.SetActive(false);
            plrRepGO.SetActive(true);
            plrRep.text = "-И почемуж это?";
            blockDia = true;
            diaPos = 8;
            Invoke("unlockDia", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && diaPos == 8 && blockDia == false)
        {
            plrRepGO.SetActive(false);
            enmRepGO.SetActive(true);
            enmRep.text = "Я и моя команда отменим его.-";
            blockDia = true;
            diaPos = 9;
            Invoke("unlockDia", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && diaPos == 9 && blockDia == false)
        {
            enmRepGO.SetActive(false);
            plrRepGO.SetActive(true);
            plrRep.text = "-Я вас остановлю!";
            blockDia = true;
            diaPos = 10;
            Invoke("unlockDia", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && diaPos == 10 && blockDia == false)
        {
            plrRepGO.SetActive(false);
            enmRepGO.SetActive(true);
            enmRep.text = "Сомниваюсь.-";
            blockDia = true;
            diaPos = 11;
            Invoke("unlockDia", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && diaPos == 11 && blockDia == false)
        {
            blockDia = true;
            SceneManager.LoadScene("Game");
        }
    }
    private void unlockDia()
    {
        blockDia = false;
    }
}
