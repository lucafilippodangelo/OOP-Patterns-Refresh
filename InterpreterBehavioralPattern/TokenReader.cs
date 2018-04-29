using System;
using System.Collections.Generic;
using System.Text;


namespace InterpreterBehavioralPattern
{
    public class TokenReader
    {
        public IExpression ReadToken(List<string> tokenList)
        {
            return ReadNextToken(tokenList);
        }

        private IExpression ReadNextToken(List<string> tokenList)
        {
            int i;
            if (int.TryParse(tokenList[1], out i))  //if the token is integer (terminal)
            {
                tokenList.RemoveAt(0);   //process terminal expression
                return new NumberExpression(i);
            }
            else
            {
                return ReadNonTerminal(tokenList);  //process nonTerminal expression
            }
        }

        private IExpression ReadNonTerminal(List<string> tokenList)
        {
            string token = tokenList[1]; //tokenList.First();
            tokenList.RemoveAt(0);   //read the symbol
            IExpression left = ReadNextToken(tokenList); //read left expression
            IExpression right = ReadNextToken(tokenList);  //read right expression

            if (token == "+")
                return new AddExpression(left, right);
            else if (token == "-")
                return new SubtractExpression(left, right);
            return null;
        }
    }
}
