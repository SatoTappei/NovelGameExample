using TMPro;
using UnityEngine;

public class MessageSequencer : MonoBehaviour
{
    [SerializeField] MessagePrinter _printer = default;
    [SerializeField] TMP_Text _textUi = default;
    [SerializeField] string[] _messages;

    int _currentIndex = -1;

    void Start()
    {
        MoveNext();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveNext();
        }
    }

    void MoveNext()
    {
        if (_messages is null or { Length: 0 }) return;

        if (_currentIndex + 1 < _messages.Length)
        {
            _currentIndex++;
            _printer?.ShowMessage();
        }
    }
}