using System;
using System.Data;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace AllAboutReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Fighter RegularRyan = new Fighter();
            ProjectManager CircleBackJack = new ProjectManager();

             //Better Way with reflection
            BetterCombat MyBetterCombat = new BetterCombat(RegularRyan);
            MyBetterCombat.RearAttack();

            MyBetterCombat = new BetterCombat(CircleBackJack);
            MyBetterCombat.RearAttack();

            
        }

    }

    public interface ICharacter
    {
        public EnumCharacterClass CharacterClass { get; }
        public void Attack(){}
    }

    public abstract class Character : ICharacter
    {
        public abstract EnumCharacterClass CharacterClass { get; }

        public void Attack()
        {
            Console.WriteLine("Character Attacks");
        }

        public void Defend()
        {
            Console.WriteLine("Character Defends");
        }

    }

    class Thief : Character
    {
        public override EnumCharacterClass CharacterClass { get { return EnumCharacterClass.Thief; } }

        public void Backstab()
        {
            Console.WriteLine("Thief Backstabs;");
        }
    }

    class ProjectManager : Character
    {
        public override EnumCharacterClass CharacterClass { get { return EnumCharacterClass.Thief; } }

        public void Backstab()
        {
            Console.WriteLine("Project Manager Backstabs;");
        }
    }

    class Salesperson : Character
    {
        public override EnumCharacterClass CharacterClass { get { return EnumCharacterClass.Thief; } }

        public void Backstab()
        {
            Console.WriteLine("Salesperson Backstabs;");
        }
    }

    class Wizard : Character
    {
        public override EnumCharacterClass CharacterClass { get { return EnumCharacterClass.Wizard; } }
    }

    class Fighter : Character
    {
        public override EnumCharacterClass CharacterClass { get { return EnumCharacterClass.Fighter; } }
    }

    class Cleric : Character
    {
        public override EnumCharacterClass CharacterClass { get { return EnumCharacterClass.Cleric; } }
    }

    public enum EnumCharacterClass
    {
        Thief,
        Fighter,
        Cleric,
        Wizard,
        ProjectManager

    }
}
