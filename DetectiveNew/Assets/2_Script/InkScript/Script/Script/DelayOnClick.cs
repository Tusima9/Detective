using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
   
[RequireComponent(typeof(Button))]
public class DelayOnClick : MonoBehaviour
{
    [SerializeField, Range(.01f, 3f)]
    private float _delay = .01f;
   
    [SerializeField, Space(10f)]
    private UnityEvent _onClick;
    
    private Button _thisButton;
    private WaitForSeconds _delayTimer;
    private float timeToWait = 0.5f;

    private void Awake()
    {
        _thisButton = GetComponent<Button>();

        _delayTimer = new WaitForSeconds(_delay);
    }

    // Start is called before the first frame update
    void Start()
    {
        _thisButton.onClick.AddListener(() => StartCoroutine(DelayedClickRoutine()));
        _thisButton.onClick.AddListener(ClickButton);
    }
    public void ClickButton()
    {
        //do not start the function if we are already in the process;
        if (IsInvoking("ReEnableButton"))
            return;

        //disable our button interactability
        _thisButton.interactable = false;

        //call our function ReenableButton in timeToWait seconds
        Invoke("ReEnableButton", timeToWait);
    }

    private void ReEnableButton()
    {
        //re-Enable the button
        _thisButton.interactable = true;
    }

    private IEnumerator DelayedClickRoutine()
    {
        yield return _delayTimer;
        _onClick.Invoke();
    }

    
}
