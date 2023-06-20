using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncScale : AudioSyncer
{
    [SerializeField] Vector3 _beatScale;
    [SerializeField ]Vector3 _restScale;

    private IEnumerator MoveToScale(Vector3 pTarget)
    {
        Vector3 _current = transform.localScale;
        Vector3 _initial = _current;
        float _timer = 0;

        while (_current != pTarget)
        {
            _current = Vector3.Lerp(_initial, pTarget, _timer / _timeToBeat);
            _timer += Time.deltaTime;

            transform.localScale = _current;

            yield return null;
        }

        _isBeat = false;
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (_isBeat)
        {
              return;
        }

        transform.localScale = Vector3.Lerp(transform.localScale, _restScale, _restSmoothTime * Time.deltaTime);
    }

    public override void OnBeat()
    {
        base.OnBeat();

        StopCoroutine("MoveToScale");
        StartCoroutine("MoveToScale", _beatScale);
    }
}
