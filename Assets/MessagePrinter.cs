using TMPro;
using UnityEngine;

public class MessagePrinter : MonoBehaviour
{
    [SerializeField] TMP_Text _textUi = default;
    [SerializeField] string _message = "";
    [SerializeField] float _speed = 1.0F;

    float _elapsed = 0; // ������\�����Ă���̌o�ߎ���
    float _interval; // �������̑҂�����

    // _message �t�B�[���h����\�����錻�݂̕����C���f�b�N�X�B
    // �����w���Ă��Ȃ��ꍇ�� -1 �Ƃ���B
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