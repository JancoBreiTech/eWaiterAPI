﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DataTransferObjects
{
    public class RestaurantImgDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public byte[] ImageFile { get; set; }
    }
}
