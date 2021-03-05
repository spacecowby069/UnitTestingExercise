using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly-DONE
            // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers-DONE
        public int Add(int one, int two, int three)
        {
            //throw new NotImplementedException();
            return one + two + three;
        }

        // Create a Subtract method that passes 2 integers-DONE
            // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
            //throw new NotImplementedException();
        }

        // Create a Multiply method that passes 2 integers
        public int Multiply(int one, int two)
        {
            //throw new NotImplementedException();
            return one * two;
        }

        // Create a Divide method that passes 2 integers
        public int Divide(int one, int two)
        {
            //throw new NotImplementedException();
            return one / two;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote
        public bool IsCharSymbol(char testChar)
        {
            return char.IsSymbol(testChar);
            
            //throw new NotImplementedException();
        }

        public bool IsCharNotSymbol(char testChar2)
        {
            return char.IsLetterOrDigit(testChar2);
            
            // throw new NotImplementedException();
        }

    }
}
