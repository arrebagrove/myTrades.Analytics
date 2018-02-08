﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrades.Analytics.Model
{
    /// <summary>
    /// Represents a historical value with date. e.g. can be a historical price from a stock or from an index. 
    /// </summary>
    public class HistoricalValue
    {
        public DateTime Date { get; set; }

		private decimal open;
        public Decimal Open
		{
			get { return Math.Round(open, 2); }
			set { open = value; }
		}
		
		private decimal high;
		public Decimal High
		{
			get { return Math.Round(high, 2); }
			set { high = value; }
		}


		private decimal low;
        public Decimal Low
		{
			get { return Math.Round(low, 2); }
			set { low = value; }
		}

		private decimal close;

		public Decimal Close
		{
			get { return Math.Round(close, 2); }
			set { close = value; }
		}

        public long Volume { get; set; }
    }
}
