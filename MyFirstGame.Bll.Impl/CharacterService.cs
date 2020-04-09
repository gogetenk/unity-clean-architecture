using System;

namespace MyFirstGame.Bll.Impl
{
    /// <summary>
    /// Totalement abstrait, uniquement de la logique métier qui n'a pas besoin d'Unity.
    /// </summary>
    public class CharacterService : ICharacterService
    {
        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
