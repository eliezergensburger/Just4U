using System;

namespace Targil2
{
    public class HostingUnit : IComparable<HostingUnit>
    {
        private static int stSerialKey = 10000000;
        private bool[,] diary;

        public bool[,] Diary
        {
            get { return diary; }
        }


        public readonly int HostingUnitKey;

        public HostingUnit()
        {
            diary = new bool[12, 31];
            HostingUnitKey = stSerialKey++;
        }

        public float GetAnnualBusyPercentage()
        {
            return (GetAnnualBusyDays() / (12f * 31f) * 100);
        }

        public override string ToString()
        {
            //TO DO
            return base.ToString();
        }
        public bool ApproveRequest(GuestRequest guestRequest)
        {
            bool result = true;
            if (1 == 1)
            {
                guestRequest.IsApproved = true;
            }
            //else
            //{
            //    guestRequest.IsApproved = false;
            //}
            return result;
        }

        public int GetAnnualBusyDays()
        {
            int result = 0;

            foreach (bool item in Diary)
            {
                result += (item) ? 1 : 0;
            }
            return result; ;
        }

        public int CompareTo(HostingUnit other)
        {
            return GetAnnualBusyDays().CompareTo(other.GetAnnualBusyDays());
        }
    }
}