public class CombatService
{
    public AttackResponseDto Attack(CharacterDto attacker, CharacterDto target)
    {
        var response = new AttackResponseDto();

        // First we calculate the damages depending on characters stats
        var damages = CalculateDamages(attacker, target);
        // Inflict damages to target
        target.Hp -= damages;
        response.DamageValue = damages;

        // Check for death
        if (target.Hp <= 0)
        {
            response.IsDead = true;
            response.TookDamage = true;
        }
        else
        {
            response.TookDamage = true;
        }

        return response;
    }

    private int CalculateDamages(CharacterDto attacker, CharacterDto target)
    {
        var delta = attacker.Attack - target.Defense;
        return delta;
    }
}
