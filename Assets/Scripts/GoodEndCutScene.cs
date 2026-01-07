using DG.Tweening;
using TMPro;
using UnityEngine;

public class GoodEndCutScene : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI textDia;
    [SerializeField]private GameObject textDiaGO;
    [SerializeField]private GameObject player;
    [SerializeField]private GameObject WinTitlButt;
    [SerializeField]private AudioSource winMus;
    [SerializeField]private AudioSource hitSound;
    [SerializeField]private AudioSource deadESound;
    [SerializeField]private GameObject enemy;
    private bool blockDia = false;
    private int posDia = 0;
    void Start()
    {
        Invoke("waitngHuh", 1f);
    }
    private void waitngHuh()
    {
        enemy.transform.DOMove(new Vector3(4.48f, -7.9f, 0), 1f);
        deadESound.Play();
        hitSound.Play();
        Invoke("startDia", 1.5f);
    }
    private void startDia()
    {
        textDiaGO.SetActive(true);
        textDia.text = "-Фух, справился.";
        posDia = 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && posDia == 1 && blockDia == false)
        {
            blockDia = true;
            textDia.text = "-Можно и новый год встречать.";
            posDia = 2;
            Invoke("unlockDia", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && posDia == 2 && blockDia == false)
        {
            blockDia = true;
            textDia.text = "-Пойду я.";
            posDia = 3;
            Invoke("unlockDia", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && posDia == 3 && blockDia == false)
        {
            winMus.Play();
            blockDia = true;
            textDiaGO.SetActive(false);
            player.transform.DOMove(new Vector3(11.6f, -0.02f, 0 ), 3.7f);
            Invoke("EmergingWinTitle", 4f);
        }
    }
    private void EmergingWinTitle()
    {
        WinTitlButt.transform.DOMove(new Vector3(960, 578, 0), 1f);
    }
    private void unlockDia()
    {
        blockDia = false;
    }
}