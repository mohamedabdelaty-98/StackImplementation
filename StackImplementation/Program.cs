using StackImplementation.StackUsingLinkedList;
using System.Runtime.CompilerServices;

namespace StackImplementation
{
    internal class Program
    {
        #region Balanced Parnthess
        //public static bool AreClosed(char open,char close)
        //{
        //    if(open=='{' && close=='}')
        //        return true;
        //    else if(open=='[' && close==']')
        //        return true;
        //    else if(open=='(' && close==')')
        //        return true;
        //    return false;
        //}
        //public static bool Balanced(string Exp)
        //{
        //    Stack<char> stack = new Stack<char>();
        //    for(int i = 0; i < Exp.Length; i++)
        //    {
        //        if (Exp[i] == '(' || Exp[i] == '{' || Exp[i] == '[')
        //            stack.Push(Exp[i]);
        //        else if (Exp[i] == ')' || Exp[i] == '}' || Exp[i] == ']')
        //        {
        //            if (stack.Count==0 || !AreClosed(stack.Peek(), Exp[i]))
        //                return false;
        //            else
        //                stack.Pop();
        //        }

        //    }
        //    return stack.Count == 0;
        //} 
        #endregion
        #region Experssion Evaluation
        //public static int GetOperatendWheigth(char op)
        //{
        //    int weigth = -1;
        //    switch(op)
        //    {
        //        case '+':
        //        case '-':
        //            weigth = 1;
        //            break;
        //        case '*':
        //        case '/':
        //            weigth = 2;
        //            break;
        //        case '$':
        //            weigth = 3;
        //            break;
        //    }
        //    return weigth;
        //}
        //public static bool IsrightAssioative(char op)
        //{
        //    return op == '$'?true:false;
        //}
        //public static bool HigherPrecedence(char op1, char op2)
        //{
        //    int operator1 = GetOperatendWheigth(op1);
        //    int operator2 = GetOperatendWheigth(op2);
        //    if (operator1 == operator2)
        //    {
        //        if (IsrightAssioative(op1))
        //            return false;
        //        else return true;
        //    }
        //    return operator1 > operator2? true:false;

        //}
        //public static bool IsOperand(char ch)
        //{
        //    if(ch>='0' && ch<='9')
        //        return true;
        //    if(ch>='a' &&ch<='z')
        //        return true;
        //    if(ch >='A' &&ch<='Z')
        //        return true;
        //    return false;
        //}
        //public static bool IsOperator(char ch)
        //{
        //    if(ch=='+'||ch=='-'||ch=='*'||ch=='/'||ch=='$')
        //        return true;
        //    return false;
        //}
        //public static string InfixToPostfix(string Exp)
        //{
        //    Stack<char> stack = new Stack<char>();
        //    string Postifix = "";
        //    for(int i=0;i<Exp.Length; i++)
        //    {
        //        if (IsOperand(Exp[i]))
        //            Postifix += Exp[i];
        //        else if (IsOperator(Exp[i]))
        //        {
        //            while (stack.Count != 0 && stack.Peek() != '(' &&
        //                HigherPrecedence(stack.Peek(), Exp[i]))
        //            {
        //                Postifix += stack.Peek();
        //                stack.Pop();
        //            }
        //            stack.Push(Exp[i]);
        //        }
        //        else if (Exp[i] == '(')
        //            stack.Push('(');
        //        else if (Exp[i] == ')')
        //        {
        //            while(stack.Count!=0 && stack.Peek()!='(')
        //            {
        //                Postifix += stack.Peek();
        //                stack.Pop();
        //            }
        //            stack.Pop();
        //        }
        //    }
        //    while(stack.Count!=0)
        //    {
        //        Postifix += stack.Peek();
        //        stack.Pop();
        //    }
        //    return Postifix;
        //}
        //public static int RemoveDuplicates(int[] nums)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    int counter = 0;
        //    int[]nums2=new int[nums.Length];
        //    for(int i=0;i<nums.Length;i++)
        //    {
        //        if (stack.Count == 0)
        //        {
        //            stack.Push(nums[i]);
        //            counter++;
        //        }
        //        else if (stack.Count!=0 && nums[i]!=stack.Peek())
        //        {
        //            stack.Push(nums[i]);
        //            counter++;
        //        }
        //    }
        //    Console.WriteLine($"{stack.Pop()}");
        //    Console.WriteLine($"{stack.Pop()}");
        //    Console.WriteLine($"{stack.Pop()}");
        //    return stack.Count;
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region Stack Using Array
            //Stackimplementation<int> stack = new Stackimplementation<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(51);
            //stack.Push(55);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            // //Console.WriteLine(stack.Peek());
            // //Console.WriteLine(stack.Peek()); 
            #endregion
            #region Stack Using Linkedlist
            //StackLinkedList<int> stackLinkedList = new StackLinkedList<int>();
            //stackLinkedList.Push(1);
            //stackLinkedList.Push(2);
            //stackLinkedList.Push(3);
            //Console.WriteLine(stackLinkedList.Pop());
            //Console.WriteLine(stackLinkedList.Pop());
            //Console.WriteLine(stackLinkedList.Peek());
            //Console.WriteLine(stackLinkedList.Peek()); 
            #endregion

            #region Balanced Parnthess
            //Console.WriteLine("Enter expression");
            //string exp = Console.ReadLine();
            //string result = Balanced(exp) ? "Balanced" : "NotBalanced";
            //Console.WriteLine(result); 
            #endregion
            #region Experssion Evaluation
            //string infix = Console.ReadLine();
            //string Postfix=InfixToPostfix(infix);
            //Console.WriteLine($"postfix is : {Postfix}"); 
            #endregion


        }
    }
}