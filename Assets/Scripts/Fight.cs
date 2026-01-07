using DG.Tweening;
using UnityEngine;

public class Fight : MonoBehaviour
{
    [SerializeField]private EnemyLogic enemyLogic;
    [SerializeField]private PlayerLogic playerLogic;
    [SerializeField]private ActionMenuP actionMenuP;
    [SerializeField]private GameObject Enemy;
    [SerializeField]private HpSys hpSys;
    [SerializeField]private GameObject hpEGO;
    [SerializeField]private GameObject hpPGO;
    [SerializeField]private GameObject player;
    [SerializeField]private GameObject deadtext;
    [SerializeField]private GameObject restartbutt;
    [SerializeField]private AudioSource musicG;
    [SerializeField]private AudioSource PlayerDead;
    [SerializeField]private AudioSource deadSound;
    [SerializeField]private TimerSys timerSys;
    [SerializeField]private GameObject timer;
    private bool blockE = false;
    public bool blockActAnim = false;
    private int whonow;
    private bool cutsceneEDead = false;
    private bool cutscenePDead = false;
    public int kills = 0;
    void Start()
    {   
        whonow = 1;
        enemyLogic.GetRandomStatsE();
        playerLogic.GetRandomStatsP();
    }
    void Update()
    {
        if (whonow == 1)
        {
            if (blockActAnim == false)
            {
                actionMenuP.EmergingActionMenu();
                blockActAnim = true;
                blockE = false;
            }
        }
        if (whonow == 2)
        {
            if (blockE == false)
            {
                blockActAnim = false;
                actionMenuP.blockP = false;
                enemyLogic.ActionLogic();
                blockE = true;
                Invoke("ChangeWhoNow", 1.5f);
            }
        }
        if (hpSys.healthE <= 0 && cutsceneEDead == false)
        {
            whonow = 0;
            deadSound.Play();
            cutsceneEDead = true;
            hpEGO.transform.DOMove(new Vector3(1196, 1020, 0), 1f);
            hpPGO.transform.DOMove(new Vector3(739, 1020, 0), 1f);
            Invoke("cutscene2", 0.5f);
        }
        if (hpSys.healthP <= 0 && cutscenePDead == false)
        {
            timer.transform.DOMove(new Vector3(960, 1171, 0), 1f);
            Destroy(timerSys);
            musicG.Stop();
            PlayerDead.Play();
            actionMenuP.missActionMenu();
            whonow = 0;
            hpEGO.transform.DOMove(new Vector3(1196, 1020, 0), 1f);
            hpPGO.transform.DOMove(new Vector3(739, 1020, 0), 1f);
            cutscenePDead = true;
            Invoke("cutsceneP2", 0.5f);
        }
    }
    private void cutsceneP2()
    {
        player.transform.DOMove(new Vector3(-4.52f, -7.77f, 0), 1f);
        Invoke("cutsceneP3", 0.5f);
    }
    private void cutsceneP3()
    {
        deadtext.transform.DOMove(new Vector3(634, 726.94f, 0), 1);
        Invoke("restartbuttEmerging", 0.5f);
    }
    private void restartbuttEmerging()
    {
        restartbutt.transform.DOMove(new Vector3(616, 540, 0), 1f);
    }
    private void cutscene2()
    {
        Enemy.transform.DOMove(new Vector3(4.48f, -7.9f, 0), 1f);
        Invoke("MoveEnemyToTop", 1f);
    }
    private void MoveEnemyToTop()
    {
        Enemy.transform.position = new Vector3(4.48f, 8.18f, 0);
        cutscene3();
    }
    private void cutscene3()
    {
        Enemy.transform.DOMove(new Vector3(4.48f, 0.13f, 0), 1f);
        Invoke("backHP", 1f);
        kills ++;
    }
    private void backHP()
    {
        whonow = 1;
        blockActAnim = false;
        actionMenuP.blockP = false;
        enemyLogic.GetRandomStatsE();
        playerLogic.GetRandomStatsP();
        cutsceneEDead = false;
        hpPGO.transform.DOMove(new Vector3(960, 1020, 0), 1f);
        hpEGO.transform.DOMove(new Vector3(960, 1020,0), 1f);
    }
    public void ChangeWhoNow4ACTP()
    {
        Invoke("ChangeWhoNow", 1.5f);
    }
    private void ChangeWhoNow()
    {
        if (whonow == 1)
        {
            whonow = 2;
        }
        else if (whonow == 2)
        {
            whonow = 1;
        }
    }
}