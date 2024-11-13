using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORC : NPCstats, DamageSystem
{
    private void Start()
    {
        DmgSystem(Orc.Attack);
        MAORE();
    }

    protected override void MAORE()
    {
        Debug.Log("Goblin got hit");
    }

    public void DmgSystem(int dmg)
    {
        Debug.Log("ORC Current HP: " + Health);
        Health -= dmg;
        Debug.Log("ORC HP: " + Health);
    }
    [SerializeField] private ORC Orc;
    public void DamageSystem(int Attack)
    {
        ((DamageSystem)Orc).DamageSystem(Attack);
    }

}