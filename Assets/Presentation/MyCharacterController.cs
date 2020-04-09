using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    public MyCharacterController Target;
    public CharacterDto CurrentCharacter;
    private CombatService _combatService;

    // Start is called before the first frame update
    private void Start()
    {
        _combatService = new CombatService();
        CurrentCharacter = new CharacterDto() // Devrait être choppé dans un autre service, ou dans un autre controller
        {
            Attack = 20,
            Defense = 20,
            Hp = 100
        };
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Attack();
    }

    private void Attack()
    {
        // Asking the BLL to do all the logic
        var response = _combatService.Attack(CurrentCharacter, Target.CurrentCharacter);
        // Getting the informations in order to play animations, effects, etc (everything that is adherent to unity engine)
        if (response.TookDamage)
        {
            PlayDamageEffect(Target, response.DamageValue);
        }

        if (response.IsDead)
        {
            PlayDeathEffect(Target);
        }
    }

    private void PlayDamageEffect(MyCharacterController target, int damages)
    {
        // Particules, sound, etc...
        Debug.Log($"Ouch ! {target.CurrentCharacter.Name} took {damages.ToString()} ! ");
    }

    private void PlayDeathEffect(MyCharacterController target)
    {
        // Particules, sound, etc...
        Debug.Log($"{target.CurrentCharacter.Name} Died !!! ! ");
    }
}
