using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercenary1 : NPCstats, DamageSystem
{
    private void Start()
    {
        DmgSystem(Merc.Attack);
        MAORE();
    }

    protected override void MAORE()
    {
        Debug.Log("Mercenary 1 got hit");
    }

    public void DmgSystem(int dmg)
    {
        Debug.Log("Mercenary Current HP: " + Health);
        Health -= dmg;
        Debug.Log("Mercenary HP: " + Health);
    }

    public void DamageSystem(int Attack)
    {
        ((DamageSystem)Merc).DamageSystem(Attack);
    }

    [SerializeField] private Mercenary1 Merc;
}