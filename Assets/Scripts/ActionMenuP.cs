using DG.Tweening;
using TMPro;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;

public class ActionMenuP : MonoBehaviour
{
    [SerializeField]private HpSys hpSys;
    [SerializeField]private PlayerLogic playerLogic;
    [SerializeField]private GameObject ActionMenu;
    [SerializeField]private Fight fight;
    [SerializeField]private TextMeshProUGUI actionT;
    [SerializeField]private GameObject actionTGO;
    [SerializeField]private TextMeshProUGUI damageET;
    [SerializeField]private TextMeshProUGUI damageETGO;
    [SerializeField]private TextMeshProUGUI healPT;
    [SerializeField]private GameObject healPTGO;
    [SerializeField]private AudioSource hit;
    [SerializeField]private AudioSource click;
    [SerializeField]private AudioSource heal;
    public bool blockP = false;
    public void AttackAct()
    {
        if (blockP == false)
        {
            click.Play();
            hit.Play();
            actionT.text = "Атака";
            damageET.text = playerLogic.damage.ToString() + "-";
            actionTGO.transform.DOMove(new Vector3(308, 587.208f, 0), 1f);
            damageETGO.transform.DOMove(new Vector3(1760.864f, 932.86f, 0), 1f);
            hpSys.healthE -= playerLogic.damage;
            fight.ChangeWhoNow4ACTP();
            missActionMenu();
            blockP = true;
            Invoke("HideTUI", 1.3f);
        }
    }
    public void HealAct()
    {
        if (blockP == false)
        {
            click.Play();
            heal.Play();
            actionT.text = "Лечение";
            healPT.text = "+" + playerLogic.healCount.ToString();
            healPTGO.transform.DOMove(new Vector3(159f, 932.86f, 0), 1f);
            actionTGO.transform.DOMove(new Vector3(308, 587.208f, 0), 1f);
            hpSys.healthP += playerLogic.healCount;
            fight.ChangeWhoNow4ACTP();
            missActionMenu();
            blockP = true;
            Invoke("HideTUI", 1.3f);
        }
    }
    public void EmergingActionMenu()
    {
        ActionMenu.transform.DOMove(new Vector3(1000.5f, 95, 0), 1f);
    }
    public void missActionMenu()
    {
        ActionMenu.transform.DOMove(new Vector3(1000.5f, -199, 0), 1f);
    }
    private void HideTUI()
    {
        actionTGO.transform.DOMove(new Vector3(-196, 587.208f, 0), 1f);
        healPTGO.transform.DOMove(new Vector3(-164, 932.86f, 0), 1f);
        damageETGO.transform.DOMove(new  Vector3(2099, 932.86f, 0), 1f);
    }
}