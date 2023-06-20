using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    [SerializeField] int _duration;
    [SerializeField] float _damagePerTurn;
    [SerializeField] float _oneTimeDamage;
    [SerializeField] float _addArmor;
    [SerializeField] float _reduceArmor;
    [SerializeField] float _addStrength;
    [SerializeField] float _reduceStrength;

    private int _remainingTurns;

    public void Activate()
    {
        _remainingTurns = _duration;
        ApplyEffects();
    }

    void NextTurn()
    {
        if (_remainingTurns > 0)
        {
            ApplyEffects();
            _remainingTurns--;
        }
        else
        {
            FinishAbility();
        }
    }

    void ApplyEffects()
    {
        if (_remainingTurns == _duration)
        {
            ApplyDamage(_oneTimeDamage);
        }
        else
        {
            ApplyDamage(_damagePerTurn);
        }

        ModifyArmor(_addArmor);
        ModifyArmor(-_reduceArmor);
    }

    void ModifyArmor(float pAmount)
    {

    }

    void ApplyDamage(float pAmount)
    {

    }

    void FinishAbility()
    {

    }
}
