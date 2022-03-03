using UnityEngine;

public class ClickToEnable : MonoBehaviour
{
    [SerializeField] MonoBehaviour _target;

    void OnMouseDown()
    {
        _target.enabled = true;

    }

}
