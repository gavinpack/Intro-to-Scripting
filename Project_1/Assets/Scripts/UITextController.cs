using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UiTextController : MonoBehaviour
{
    private Text _textLabel;

    public void UpdateText(IntData data)
    {
        _textLabel.text = data.value.ToString();
    }
    void Awake()
    {
        _textLabel = GetComponent<Text>();
    }
}
