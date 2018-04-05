using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class STARR_portfolio
    {
        private List<STARR> starrHistory = new List<STARR>();

        public List<STARR> STARRHistory { get => STARRHistory; set => STARRHistory = value; }
    }
}
