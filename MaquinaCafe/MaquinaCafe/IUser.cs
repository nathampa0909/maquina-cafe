using System;
using System.Collections.Generic;
using System.Text;

namespace MaquinaCafe
{
    public class IUser
    {
        private HotWaterSource hws;
        private ContainmentVessel cv;
        public void Done() { }

        public void Complete() { }

        protected void StartBrewing() { if (hws.IsReady() && cv.IsReady()) { hws.Start(); cv.Start(); } }
    }
}
