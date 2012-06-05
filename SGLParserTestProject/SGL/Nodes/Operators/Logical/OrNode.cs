﻿using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Operators.Logical
{
    class OrNode : AbstractBinaryOperatorNode
    {
        public OrNode(AbstractNode node1, AbstractNode node2) : base(node1, node2) { }

        public override Value Operate(Value value1, Value value2)
        {
            if (value1.Type == ValType.Boolean && value2.Type == ValType.Boolean)
            {
                return new Value(value1.BoolValue || value2.BoolValue, ValType.Boolean);
            }
            else
            {
                throw new CompilerException(Line, 202, "||", value1.TypeString, value2.TypeString);
            }
        }
    }
}
