using System;
using System.Collections.Generic;
using System.Text;

namespace MaquinaCafe
{
    public class M4HotWaterSource : HotWaterSource
    {
        public override bool IsReady()
        {
            BoilerStatus status = CoffeeMaker.api.GetBoilerStatus();
            return status == BoilerStatus.NOT_EMPTY;
        }
    }
}