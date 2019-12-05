using System.Collections;
using UnityEngine;

public class GameActionRaiser : MonoBehaviour
{
    public float holdTime = 1f;
    public WaitForSeconds waitForSeconds;
    private bool _canRun = true;
    public GameAction gameActionObj;

    private void Awake()
    {
        waitForSeconds = new WaitForSeconds(holdTime);
    }
    private IEnumerator OnMouseDown()
    {
        _canRun = true;
        while (_canRun)
        {
            gameActionObj.Raise();
            yield return waitForSeconds;
        }
    }

    private void OnMouseUp()
    {
        _canRun = false;
    }
}
