using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowman : PlayerStats, DamageSystem
{
    private void Start()
    {
        DamageSystem(bowman.Attack);
        MAORE();
    }

    protected override void MAORE()
    {
        Debug.Log("Bowman got hit");
    }

    public void DmgSystem(int dmg)
    {
        Debug.Log("Bowman Current HP: " + Health);
        Health -= dmg;
        Debug.Log("Bowman HP: " + Health);
    }
    [SerializeField] private Bowman bowman;
    public void DamageSystem(int Attack)
    {
        ((DamageSystem)bowman).DamageSystem(Attack);
    }
}

