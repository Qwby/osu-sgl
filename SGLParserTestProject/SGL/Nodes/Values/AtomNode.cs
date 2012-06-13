﻿using System;
using System.Collections.Generic;
using System.Text;
using SGL.Nodes;
using SGL.Elements;
using SGL.Storyboard;

namespace SGL.Nodes.Values
{
    class AtomNode : AbstractNode
    {
        private Value value;
        private int line = -1;

        public AtomNode(object value, ValType type)
        {
            if (type == ValType.String)
            {
                // escape sequences
                String newString = (String)value;
                newString = newString.Replace("\\\\", "\\");
                newString = newString.Replace("\\\"", "\"");
                value = newString;
            }

            this.value = (value == null) ? Value.NULL : new Value(value,type);
        }

        public AtomNode(object value, ValType type, int line)
            : this(value, type)
        {
            this.line = line;
        }

        protected override Value Invoke()
        {
            return value;
        }

        public override int Line
        {
            get
            {
                return line;
            }
        }
    }
}
