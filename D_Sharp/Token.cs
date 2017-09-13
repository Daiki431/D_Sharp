﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Sharp
{
    enum TokenType
    {
        Double,
        Identifier,
        symbol
    }

    class Token
    {
        readonly string str;

        readonly TokenType tokenType;

        public Token(string str, TokenType tokenType)
        {
            this.str = str;
            this.tokenType = tokenType;
        }

        public string Str { get { return str; } }

        public TokenType TokenType { get { return tokenType; } }

        public double GetDouble()
        {
            if (tokenType != TokenType.Double)
                throw new Exception("ばーか");
            return double.Parse(str);
        }

        public void DebugPrint()
        {
            Console.WriteLine("STR=" + str + " : Type" + tokenType.ToString());
        }

    }
}
