using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public EnemyObject enemySettings;


    private Animator anim;
    public string name;

    [Header("Características Físicas")]
    public int forca;
    public int vigor;
    public int destreza;
    [Header("Características Mentais")]
    public int assimilacao;
    public int influencia;
    public int sabedoria;
    [Header("Características Variáveis")]
    public int currentVit;
    public int currentCon;
    public int maxVit;
    public int maxCon;

    private int randomVit;
    private int randomCon;

    private void CalcVit()
    {
        int dado = Random.Range(1, 7);
        randomVit = dado;
    }

    private void CalcCon()
    {
        int dado = Random.Range(1, 7);
        randomCon = dado;
    }

    void Start()
    {

        anim = GetComponent<Animator>();
        anim.runtimeAnimatorController = enemySettings.animController;

        name =  enemySettings.name;

        forca = enemySettings.forca;
        vigor = enemySettings.vigor;
        destreza = enemySettings.destreza;

        assimilacao = enemySettings.assimilacao;
        influencia = enemySettings.influencia;
        sabedoria = enemySettings.sabedoria;

        CalcVit();
        maxVit = randomVit + forca + vigor;
        CalcCon();
        maxCon = randomCon + sabedoria + influencia;

        currentVit = maxVit;
        currentCon = maxCon;

    }

}
