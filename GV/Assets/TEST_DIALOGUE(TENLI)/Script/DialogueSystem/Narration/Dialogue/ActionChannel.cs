using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Scriptable Objects/Actions/ActionChannel")]
public class ActionChannel : ScriptableObject
{
    // Start is called before the first frame update
    public delegate void CallActionOnDialog(Action actions);

    public CallActionOnDialog callActions;

    public void requestAction(Action actions)
    {
        callActions?.Invoke(actions);
    }
}
