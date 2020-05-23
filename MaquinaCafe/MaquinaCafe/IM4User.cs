using System;
using System.Collections.Generic;
using System.Text;

namespace MaquinaCafe
{
    public class IM4User : IUser
    {
        private void CheckButton()
        {
            BrewButtonStatus status = CoffeeMaker.api.GetBrewButtonStatus();
            if (status == BrewButtonStatus.PUSHED)
            {
                StartBrewing();
            }
        }

    }
}
