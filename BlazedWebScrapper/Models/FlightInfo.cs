﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapper
{
	public class FlightInfo
	{
        public FlightInfo(string there, string back)
        {
            There = there;
            Back = back;
        }

        public string There { get; set; }
        public string Back { get; set; }
    }
}
