using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioSyncer : MonoBehaviour
{
    [SerializeField] protected float _bias;
    [SerializeField] protected float _timeStep;
    [SerializeField] protected float _timeToBeat;
    [SerializeField] protected float _restSmoothTime;

    protected float _previousAudioValue;
    protected float _audioValue;
    protected float _timer;

    protected bool _isBeat;

    // Update is called once per frame
    void Update()
    {
        OnUpdate();
    }

    public virtual void OnUpdate()
    {
        _previousAudioValue = _audioValue;
        _audioValue = AudioSpectrum._spectrumValue;


        if (_previousAudioValue > _bias && _audioValue <= _bias)
        {
            if (_timer > _timeToBeat)
            {
                OnBeat();
            }
        }

        if (_previousAudioValue <= _bias && _audioValue > _bias)
        {
            if (_timer > _timeToBeat)
            {
                OnBeat();
            }
        }

        _timer += Time.deltaTime;
    }

    public virtual void OnBeat()
    {
        _timer = 0;
        _isBeat = true;
    }
}
