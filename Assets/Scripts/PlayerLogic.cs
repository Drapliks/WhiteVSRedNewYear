using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField]private HpSys hpSys;
    public int damage = 0;
    public int healCount = 0;

    public void GetRandomStatsP()
    {
        hpSys.maxHpP = Random.Range(25,51);
        damage = Random.Range(7,14);
        healCount = Random.Range(3,6);
        hpSys.healthP = hpSys.maxHpP;
    }

}