using DG.Tweening;
using TMPro;
using UnityEngine;

public class BadEndCutScene : MonoBehaviour
{
    [SerializeField]private GameObject Enemy;
    [SerializeField]private GameObject player;
    [SerializeField]private GameObject textDiaGO;
    [SerializeField]private TextMeshProUGUI textDia;
    [SerializeField]private GameObject yearCounter;
    [SerializeField]private TextMeshProUGUI yearCounterText;
    [SerializeField]private AudioSource changeYearSound;
    [SerializeField]private AudioSource hitSound;
    [SerializeField]private GameObject all;
    [SerializeField]private GameObject allGO;
    private int posDia = 0;
    private bool blockDia;
    void Start()
    {
        Enemy.transform.DOMove(new Vector3(-4.52f, 0.13f, 0 ), 0.7f);
        Invoke("BamP", 0.3f);
    }
    private void BamP()
    {
        hitSound.Play();
        player.transform.DOMove(new Vector3(-4.52f, -1.97f, 0), 0.4f);
        player.transform.DOScale(new Vector3(2.131149f, 0.03111211f, 2.131149f), 0.4f);
        Invoke("MoveToDia", 1f);
    }
    private void MoveToDia()
    {
        textDiaGO.SetActive(true);
        textDia.text = "Ну наконец подмога пришла.-";
        posDia = 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && posDia == 1 && blockDia == false)
        {
            blockDia = true;
            textDia.text = "Давайте быстрее отменяйте новый год.-";
            posDia = 2;
            Invoke("unlockDia", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && posDia == 2 && blockDia == false)
        {
            blockDia = true;
            textDiaGO.SetActive(false);
            yearCounter.transform.DOMove(new Vector3(960, 925, 0), 1f);
            Invoke("changeYear", 1.4f);
        }
    }
    private void changeYear()
    {
        yearCounterText.text = "2025";
        changeYearSound.Play();
        Invoke("EmergingLoseTitle", 1.5f);
    }
    private void EmergingLoseTitle()
    {
        allGO.transform.DOMove(new Vector3(-4.52f, -8.07f, 0), 1f);
        all.transform.DOMove(new Vector3(960, -274, 0), 1f);
    }
    private void unlockDia()
    {
        blockDia = false;
    }
}