using UnityEngine;

public enum EquipmentType
{
    Armor,
    Weapon,
}


[CreateAssetMenu(fileName = "ItemAttributes", menuName = "Item/EquippableObject")]
public class EquippableItem : Item
{
    [Header("Básico")]
    public int Pes;
    public int Res;

    [Space]
    public EquipmentType EquipmentType;

    [Space]
    [Header ("Bônus em Danos Naturais")]
    public int Atk_Corte;
    public int Atk_Contusão;
    public int Atk_Perfuração;
    public int Atk_Explosão;
    [Header("Bônus em Danos Elementais")]
    public int Atk_Fogo;
    public int Atk_Gelo;
    public int Atk_Terra;
    public int Atk_Água;
    public int Atk_Vento;
    public int Atk_Trovão;
    [Header("Bônus em Danos Especiais")]
    public int Atk_Necrótico;
    public int Atk_Mágico;

    [Space]
    [Header("Bônus em Proteções Naturais")]
    public int Def_Corte;
    public int Def_Contusão;
    public int Def_Perfuração;
    public int Def_Explosão;
    [Header("Bônus em ProteçõesElementais")]
    public int Def_Fogo;
    public int Def_Gelo;
    public int Def_Terra;
    public int Def_Água;
    public int Def_Vento;
    public int Def_Trovão;
    [Header("Bônus em Proteções Especiais")]
    public int Def_Necrótico;
    public int Def_Mágico;

    [Space]
    [Header("Características Físicas")]
    public int F_Bonus;
    public int V_Bonus;
    public int D_Bonus;
    [Header("Características Mentais")]
    public int A_Bonus;
    public int I_Bonus;
    public int S_Bonus;
    [Header("Características Variáveis")]
    public int Vit_Bonus;
    public int Con_Bonus;
}
