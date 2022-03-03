using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "enemyAttributes", menuName = "Enemy/EnemyObject")]
public class EnemyObject : ScriptableObject
/* 
Jovem.    3CF 1CM 1Asp 1Seg +3Vit +2Con.
Adulto.   2CF 1CM 2Asp 0Seg +4Vit +3Con.
Veterano. 2CF 1CM 3Asp 0Seg +2Vit +4Con.
*/
{
    public RuntimeAnimatorController animController;
    public string name;
    [Space]
    public int forca;
    public int vigor;
    public int destreza;
    [Space]
    public int assimilacao;
    public int influencia;
    public int sabedoria;
}