/*
 * Copyright (C) Kimmo Oinonen
 *
 * This file is part of homework project in Object-Oriented
 * and GUI Programming class in JAMK.
 *
 * Created: 2.2.2016
 * Author: Kimmo Oinonen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class TV
    {
        public string ShowName { get; set; }
        public string Channel { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Info { get; set; }

        public override string ToString()
        {
            return "Name of the show: " + ShowName + " Channel: " + Channel + " Start time: " + StartTime + " End time: " + EndTime + " Show info: " + Info;
        }
    }
}
