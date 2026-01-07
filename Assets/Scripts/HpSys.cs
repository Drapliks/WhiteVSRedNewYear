using System.Security.Principal;
using TMPro;
using UnityEngine;

public class HpSys : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI hpPT;
    [SerializeField]private TextMeshProUGUI hpET;
    public int healthP;
    public int healthE;
    public int maxHpP;
    public int maxHpE;
    void Update()
    {
        if (healthP > maxHpP)
        {
            healthP = maxHpP;
        }
        if (healthE > maxHpE)
        {
            healthE = maxHpE;
        }
        if (healthP < 0)
        {
            healthP = 0;
        }
        if (healthE < 0)
        {
            healthE = 0;
        }
        hpPT.text = healthP.ToString();
        hpET.text = healthE.ToString();        
    }
}
