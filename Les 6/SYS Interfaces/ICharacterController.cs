using System;
using System.Collections.Generic;
using System.Text;

namespace SYS_Interfaces
{
    public interface ICharacterController
    {
        void SetCharacter(ICharacter character);

        void Logic(float frametime);
        
    }

    public class CPUController : ICharacterController
    {
        public void Logic(float frametime)
        {
            throw new NotImplementedException();
        }

        public void SetCharacter(ICharacter character)
        {
            throw new NotImplementedException();
        }
    }

    public class PlayerController : ICharacterController
    {

        IInputDevice inputKey;
        public PlayerController(IInputDevice inputKey)
        {
            this.inputKey = inputKey;
        }

        public void Logic(float frametime)
        {
            if (inputKey.IsDown(GameButton.HIT))
            {

            }
            if (inputKey.IsDown(GameButton.DODGE))
            {

            }
            if (inputKey.IsDown(GameButton.JUMP)) { 
            }
        }

        public void SetCharacter(ICharacter character)
        {
            throw new NotImplementedException();
        }
    }
}
