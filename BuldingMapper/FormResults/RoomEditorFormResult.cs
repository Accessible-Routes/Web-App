﻿using BuildingMapper.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMapper.FormResults
{
    public class RoomEditorFormResult : FormResult
    {
        public RoomEditorFormResult() 
        { 
            Room = new Room();
        }
        public Room Room { get; set; }
    }
}
