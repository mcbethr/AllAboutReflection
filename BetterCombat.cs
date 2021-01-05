using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AllAboutReflection
{
    public class BetterCombat
    {
       
        ICharacter _CurrentCharacter;

        public BetterCombat(ICharacter CurrentCharacter)
        {
            _CurrentCharacter = CurrentCharacter;
        }

        public void RearAttack()
        {
            var CharacterType = _CurrentCharacter.GetType();

            MethodInfo BackStabMethodInfo = CharacterType.GetMethod("Backstab");

            if (BackStabMethodInfo == null)
            {
                _CurrentCharacter.Attack();
            }
            else
            {
                object BackStabCharacterInstance = Activator.CreateInstance(CharacterType, null);
                BackStabMethodInfo.Invoke(BackStabCharacterInstance, null);
            }


        }
    }
    
}
