using UnityEngine;

public enum EquipmentType
{
    Armor,
    Weapon,
}


[CreateAssetMenu(fileName = "ItemAttributes", menuName = "Item/EquippableObject")]
public class EquippableItem : Item
{
    [Header("B�sico")]
    public int Pes;
    public int Res;

    [Space]
    public EquipmentType EquipmentType;

    [Space]
    [Header ("B�nus em Danos Naturais")]
    public int Atk_Corte;
    public int Atk_Contus�o;
    public int Atk_Perfura��o;
    public int Atk_Explos�o;
    [Header("B�nus em Danos Elementais")]
    public int Atk_Fogo;
    public int Atk_Gelo;
    public int Atk_Terra;
    public int Atk_�gua;
    public int Atk_Vento;
    public int Atk_Trov�o;
    [Header("B�nus em Danos Especiais")]
    public int Atk_Necr�tico;
    public int Atk_M�gico;

    [Space]
    [Header("B�nus em Prote��es Naturais")]
    public int Def_Corte;
    public int Def_Contus�o;
    public int Def_Perfura��o;
    public int Def_Explos�o;
    [Header("B�nus em Prote��esElementais")]
    public int Def_Fogo;
    public int Def_Gelo;
    public int Def_Terra;
    public int Def_�gua;
    public int Def_Vento;
    public int Def_Trov�o;
    [Header("B�nus em Prote��es Especiais")]
    public int Def_Necr�tico;
    public int Def_M�gico;

    [Space]
    [Header("Caracter�sticas F�sicas")]
    public int F_Bonus;
    public int V_Bonus;
    public int D_Bonus;
    [Header("Caracter�sticas Mentais")]
    public int A_Bonus;
    public int I_Bonus;
    public int S_Bonus;
    [Header("Caracter�sticas Vari�veis")]
    public int Vit_Bonus;
    public int Con_Bonus;
}
