using System;
using System.Collections.Generic;
using System.Text;

namespace AllAboutReflection
{
    public class Combat
    {
        ICharacter _CurrentCharacter;

        public Combat (ICharacter CurrentCharacter)
        {
            _CurrentCharacter = CurrentCharacter;
        }
        
        public void RearAttack()
        {
            switch(_CurrentCharacter.CharacterClass)
            {
                case EnumCharacterClass.Thief:
                {
                        Thief MyThief = new Thief();
                        MyThief.Backstab();
                }
                break;
                case EnumCharacterClass.ProjectManager:
                    {
                        ProjectManager MyProjectManager = new ProjectManager();
                        MyProjectManager.Backstab();
                    }
                    break;
                case EnumCharacterClass.Wizard:
                    {
                        _CurrentCharacter.Attack();
                    }
                break;
                case EnumCharacterClass.Fighter:
                    {
                        _CurrentCharacter.Attack();
                    }
                    break;
                case EnumCharacterClass.Cleric:
                    {
                        _CurrentCharacter.Attack();
                    }
                    break;
            }


        }
        

    }
}
