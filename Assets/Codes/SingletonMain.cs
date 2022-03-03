using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMain : MonoBehaviour
{
    public static SingletonMain main { get; private set; }

    public ResponseEvent responseEvent          { get; private set; }
    public TypewriterEffect typewriterEffect    { get; private set; }
    public DialogueUI dialogueUI                { get; private set; }

    void Awake()
    {
        if (main != null)
        {
            Destroy(this.gameObject);
            return;
        }
    }
}

/*

 OBS.:
O main � colocado sempre no m�todo Awake com o seguinte c�digo ->

 void Awake()
    {
        if (main != null)
        {
            Destroy(this.gameObject);
            return;
        }
    }

-----------------------------


Exemplo do Player:

public PlayerMov playerMov { get; private set; }

Ent�o coloco o c�digo de cima no Awake do PlayerMov,
crio um GameObject Prefab com o SingletonMain chamado Main, 
crio um GameObject com o PlayerMov como filho do Main.


-----------------------------

 * Ideias de GameObjects atrelados ao MainSingleton:
. Caixas de Di�logo.
. Alertas.
. Tela de de Morte (DiedScreen).
. Biblioteca de Fontes.
. Combate?
. Praticamente todas as UI
. Audio Manager.
. Music Manager.
. Particle Manager.

 */
