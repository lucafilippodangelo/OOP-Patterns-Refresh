
namespace InterpreterBehavioralPattern
{
    //LDINT003 - terminal expression
    public class NumberExpression : IExpression
    {
        int number;
        public NumberExpression(int i)
        {
            number = i;
        }

        int IExpression.Interpret()
        {
            return number;
        }
    }

    //LDINT004 - nonterminal expression, contains left and right expressions below it
    public class AddExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        int IExpression.Interpret()
        {
            return leftExpression.Interpret() + rightExpression.Interpret();
        }
    }

    //LDINT005 - nonterminal expression, contains left and right expressions below it
    public class SubtractExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public SubtractExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        int IExpression.Interpret()
        {
            return leftExpression.Interpret() - rightExpression.Interpret();
        }
    }
}
