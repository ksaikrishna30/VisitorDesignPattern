﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public interface IVisitable
    {
        public void accept(IVisitor visitor);
    }
}
