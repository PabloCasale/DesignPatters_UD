﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IListStrategy
    {
        void Start(StringBuilder sb);

        void End(StringBuilder sb);

        void AddListItem(StringBuilder sb, string item);
    }
}