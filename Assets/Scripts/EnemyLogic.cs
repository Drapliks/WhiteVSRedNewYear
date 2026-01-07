using DG.Tweening;
using TMPro;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    [SerializeField]private HpSys hpSys;
    [SerializeField]private GameObject actionTGO;
    [SerializeField]private TextMeshProUGUI actionT;
    [SerializeField]private GameObject damagePTGO;
    [SerializeField]private TextMeshProUGUI damagePT;
    [SerializeField]private TextMeshProUGUI healET;
    [SerializeField]private GameObject healETGO;
    [SerializeField]private AudioSource hit;
    [SerializeField]private AudioSource click;
    [SerializeField]private AudioSource heal;
    private int damage = 0;
    private int healCount = 0;
    private int action;
    private int type;

    public void GetRandomStatsE()
    {
        type = Random.Range(1,4);
        hpSys.maxHpE = Random.Range(25,51);
        damage = Random.Range(7,14);
        healCount = Random.Range(3,6);
        hpSys.healthE = hpSys.maxHpE;
    }
    public void ActionLogic()
    {
        if (type == 1)
        {
            action = Random.Range(1,3);
            if (action == 1)
            {
                click.Play();
                hit.Play();
                actionT.text = "Атака";
                damagePT.text = "-" + damage.ToString();
                damagePTGO.transform.DOMove(new Vector3(159f, 932.86f, 0), 1f);
                actionTGO.transform.DOMove(new Vector3(1663, 587.208f, 0), 1f);
                hpSys.healthP -= damage;
                Invoke("HideTUI", 1.3f);
            }
            else if (action == 2)
            {
                click.Play();
                heal.Play();
                healET.text = healCount.ToString() + "+";
                actionT.text = "Лечение";
                healETGO.transform.DOMove(new Vector3(1760.864f, 932.86f, 0), 1f);
                actionTGO.transform.DOMove(new Vector3(1663, 587.208f, 0), 1f);
                hpSys.healthE += healCount;
                Invoke("HideTUI", 1.3f);
            }
        }
        if (type == 2)
        {
            action = Random.Range(1,4);
            if (action == 1)
            {
                click.Play();
                hit.Play();
                actionT.text = "Атака";
                damagePT.text = "-" + damage.ToString();
                damagePTGO.transform.DOMove(new Vector3(159f, 932.86f, 0), 1f);
                actionTGO.transform.DOMove(new Vector3(1663, 587.208f, 0), 1f);
                hpSys.healthP -= damage;
                Invoke("HideTUI", 1.3f);
            }
            if (action == 2)
            {
                click.Play();
                hit.Play();
                actionT.text = "Атака";
                damagePT.text = "-" + damage.ToString();
                damagePTGO.transform.DOMove(new Vector3(159f, 932.86f, 0), 1f);
                actionTGO.transform.DOMove(new Vector3(1663, 587.208f, 0), 1f);
                hpSys.healthP -= damage;
                Invoke("HideTUI", 1.3f);
            }
            else if (action == 3)
            {
                click.Play();
                heal.Play();
                healET.text = healCount.ToString() + "+";
                actionT.text = "Лечение";
                healETGO.transform.DOMove(new Vector3(1760.864f, 932.86f, 0), 1f);
                actionTGO.transform.DOMove(new Vector3(1663, 587.208f, 0), 1f);
                hpSys.healthE += healCount;
                Invoke("HideTUI", 1.3f);
            }
        }
        if (type == 3)
        {
            action = Random.Range(1,4);
            if (action == 1)
            {
                click.Play();
                hit.Play();
                actionT.text = "Атака";
                damagePT.text = "-" + damage.ToString();
                damagePTGO.transform.DOMove(new Vector3(159f, 932.86f, 0), 1f);
                actionTGO.transform.DOMove(new Vector3(1663, 587.208f, 0), 1f);
                hpSys.healthP -= damage;
                Invoke("HideTUI", 1.3f);
            }
            else if (action == 2)
            {
                click.Play();
                heal.Play();
                healET.text = healCount.ToString() + "+";
                actionT.text = "Лечение";
                healETGO.transform.DOMove(new Vector3(1760.864f, 932.86f, 0), 1f);
                actionTGO.transform.DOMove(new Vector3(1663, 587.208f, 0), 1f);
                hpSys.healthE += healCount;
                Invoke("HideTUI", 1.3f);
            }
            else if (action == 3)
            {
                click.Play();
                heal.Play();
                healET.text = healCount.ToString() + "+";
                actionT.text = "Лечение";
                healETGO.transform.DOMove(new Vector3(1760.864f, 932.86f, 0), 1f);
                actionTGO.transform.DOMove(new Vector3(1663, 587.208f, 0), 1f);
                hpSys.healthE += healCount;
                Invoke("HideTUI", 1.3f);
            }
        }
        
    }
    private void HideTUI()
    {
        healETGO.transform.DOMove(new  Vector3(2099, 932.86f, 0), 1f);
        actionTGO.transform.DOMove(new Vector3(2086, 587.208f, 0), 1f);
        damagePTGO.transform.DOMove(new Vector3(-164, 932.86f, 0), 1f);
    }
}