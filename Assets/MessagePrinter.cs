using TMPro;
using UnityEngine;

public class MessagePrinter : MonoBehaviour
{
    [SerializeField] TMP_Text _textUi = default;
    [SerializeField] string _message = "";
    [SerializeField] float _speed = 1.0F;

    float _elapsed = 0; // 文字を表示してからの経過時間
    float _interval; // 文字毎の待ち時間

    // _message フィールドから表示する現在の文字インデックス。
    // 何も指していない場合は -1 とする。
    int _currentIndex = -1;

    void Start()
    {
        if (_textUi is null) { return; }

        _textUi.text = "";
        _interval = _speed / _message.Length;
    }

    void Update()
    {
        if (_textUi is null || _message is null || _currentIndex + 1 >= _message.Length) { return; }

        _elapsed += Time.deltaTime;
        if (_elapsed > _interval)
        {
            _elapsed = 0;
            _currentIndex++;
            _textUi.text += _message[_currentIndex];
        }
    }
}