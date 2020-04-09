using System;
using Xunit;
using FluentAssertions;

namespace MyFirstGame.UnitTests
{
    public class CombatTests
    {
        [Fact]
        public void Attack_WhenNoMoreHp_ExpectTargetDied()
        {
            // Arrange
            var player = new CharacterDto();
            player.Attack = 10;
            var target = new CharacterDto();
            player.Defense = 1;
            player.Hp = 1;

            var service = new CombatService();

            // Act
            var result = service.Attack(player, target);
            result.IsDead.Should().BeTrue();
        }
    }
}
