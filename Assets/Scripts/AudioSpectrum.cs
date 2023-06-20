using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpectrum : MonoBehaviour
{
    private float[] _audioSpectrum;
    public static float _spectrumValue;

    void Start()
    {
        _audioSpectrum = new float[128];
    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.GetSpectrumData(_audioSpectrum, 0, FFTWindow.Hamming);

        if (_audioSpectrum != null && _audioSpectrum.Length > 0)
        {
            _spectrumValue = _audioSpectrum[0] * 300;
        }
    }
}
