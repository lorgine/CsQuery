﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsQuery.Implementation;

namespace CsQuery.HtmlParser
{
    public class IterationData
    {
        public IterationData Parent;
        public IDomObject Object;
        public DomElement Element
        {
            get
            {
                return (DomElement)Object;
            }
        }
        // when true, the contents will be treated as text until the next close tag
        public bool ReadTextOnly;
        public int Pos;
        public byte Step;
        public bool Finished;
        public bool AllowLiterals;
        public bool Invalid;
        public int HtmlStart;
        
        /// <summary>
        /// Use this to prepare the iterator object to continue finding siblings. It retains the parent. It just avoids having to recreate
        /// an instance of this object for the next tag.
        /// </summary>
        public void Reset()
        {
            Step = 0;
            HtmlStart = Pos;
            ReadTextOnly = false;
            Object = null;
        }
        public void Reset(int pos)
        {
            Pos = pos;
            Reset();
        }
    }
}
