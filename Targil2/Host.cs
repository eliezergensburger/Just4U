using System;
using System.Collections;
using System.Collections.Generic;

namespace Targil2
{
    public class Host: IEnumerable<HostingUnit>
    {
        private int Id;
        public int ID { get => Id;  private set => Id = value; }

        private List<HostingUnit> hostingUnits;

        public Host(int Id, int NumHostingUnits)
        {
            this.ID = Id;
            hostingUnits = new List<HostingUnit>(NumHostingUnits);
        }

        public List<HostingUnit> HostingUnitCollection { get => hostingUnits;}
  
        private long SubmitRequest(GuestRequest guestRequest)
        {
            //TO DO
            return 19999999; // or -1
        }

        public bool AssignRequests(params GuestRequest[] gs)
        {
            bool result = true;
            //TO DO
            foreach (var req in gs)
            {
               if( SubmitRequest(req) == -1)
                {
                    result = false;
                }
            }
            return result;
        }

        public IEnumerator<HostingUnit> GetEnumerator()
        {
            return hostingUnits.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public HostingUnit this[int serialNb]
        {
            get
            {
                HostingUnit result = null;
                foreach (var item in hostingUnits)
                {
                    if(item.HostingUnitKey== serialNb)
                    {
                        result = item;
                        break;
                    }
                }
                return result;
            }
        }

        public void SortUnits()
        {
            hostingUnits.Sort();
        }
    }
}
