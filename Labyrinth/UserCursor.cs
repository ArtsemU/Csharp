using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrinth
{
    class UserCursor
    {
        (int, int) currentPosition;
        public UserCursor()
        {

        }

        public (int, int) GetCurrentPosition()
        {
            return currentPosition;
        }
    }
}
