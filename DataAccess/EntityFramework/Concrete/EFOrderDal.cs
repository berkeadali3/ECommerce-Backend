﻿using Core.DataAccess.EntityFramework;
using DataAccess.EntityFramework.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework.Concrete
{
    public class EFOrderDal: EFBaseRepository<Order, NorthwindContext>,IOrderDal
    {
    }
}
