using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Bodmas
    {
        internal void Accept()
        {
            //operator stack
            Stack<char> stk1 = new();
            //number stack
            Stack<int> stk2 = new();

            Console.WriteLine("Enter an Expression: ");
            string inp = Console.ReadLine();
            string input = "(" + inp + ")";

            StringBuilder sb = new(input.Length);
            foreach (char c in input)
            {
                if (!char.IsWhiteSpace(c))
                    sb.Append(c);
            }
            string exp = sb.ToString();
            Console.WriteLine(exp);

            string operators = "+-*/()";
            int number = 0;
            bool buildingNumber = false;

            foreach (char i in exp)
            {
                if (Char.IsDigit(i))
                {
                    number = number * 10 + (i - '0');
                    buildingNumber = true;
                }
                else if (operators.Contains(i))
                {
                    if (buildingNumber)
                    {
                        stk2.Push(number);
                        number = 0;
                        buildingNumber = false;
                    }
                    if (i == '(')
                    {
                        stk1.Push(i);
                    }
                    else if (i == ')')
                    {
                        while (stk1.Peek() != '(')
                        {
                            EvaluateTop(stk1, stk2);
                        }
                        stk1.Pop();
                    }

                    else
                    {
                        while (stk1.Count > 0 &&
                               stk1.Peek() != '(' &&
                               Precedence(stk1.Peek()) >= Precedence(i))
                        {
                            EvaluateTop(stk1, stk2);
                        }
                        stk1.Push(i);
                    }

                }
            }

            if (buildingNumber)
            {
                stk2.Push(number);
            }

            while (stk1.Count > 0)
            {
                EvaluateTop(stk1, stk2);
            }
            Console.WriteLine(stk2.Peek());
        }
        private void EvaluateTop(Stack<char> opStack, Stack<int> valStack)
        {
            char oper = opStack.Pop();
            int b = valStack.Pop();
            int a = valStack.Pop();
            valStack.Push(Operation(oper, a, b));
        }

        internal int Operation(char oper, int a, int b)
        {
            return oper switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => a / b,// integer division
                _ => throw new InvalidOperationException("Invalid operator"),
            };
        }
        internal int Precedence(char op)
        {
            return op switch
            {
                '+' or '-' => 1,
                '*' or '/' => 2,
                _ => 0
            };
        }
    }
}













//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{
//    internal class Bodmas
//    {
//        internal void Accept()
//        {
            //Console.WriteLine("Enter an Expression: ");
            //string inp = Console.ReadLine();
            //string exp = "("+inp+")";
            //Console.WriteLine(exp);
            //Stack<char> stk1 = new();
            //Stack<int> stk2 = new();
            //char oper;
            //int a, b;
            //string input = Console.ReadLine();
            //StringBuilder sb = new(input.Length);
            //foreach (char c in input)
            //{
            //    if (!char.IsWhiteSpace(c))
            //        sb.Append(c);
            //}
            //string exp = sb.ToString();
            //Console.WriteLine(exp);
            //string operators = "+-*/()";
            ////int leng = exp.Length;
            //foreach (char i in exp)
            //{
            //    if (Char.IsDigit(i))
            //    {
            //        stk2.Push(i - '0');
            //    }
            //    else if (operators.Contains(i))
            //    {
                    //comment
                    //char top;
                    //if(stk1.Count == 0)
                    //{
                    //    stk1.Push(i);
                    //    continue;
                    //}
                    //else
                    //{
                    //    top = stk1.Peek();
                    //}
                    //comment end

                    //if (i == '(')
                    //{
                    //    stk1.Push(i);
                    //    //continue;
                    //}
                    //else if (i == ')')
                    //{

                        //comment end
                        //bool run = true;
                        //while (run)
                        //{
                        //    oper = stk1.Pop();
                        //    if (oper != '(')
                        //    {
                        //        b = Convert.ToInt16(stk2.Pop());
                        //        a = Convert.ToInt16(stk2.Pop());
                        //        ans = Operation(oper, a, b);
                        //        stk2.Push(int.Parse(ans.ToString()));
                        //    }
                        //    else if (oper == '(')
                        //    {
                        //        run = false;
                        //    }

                        //}
                        //comment end

                    //    while (stk1.Peek() != '(')
                    //    {
                    //        oper = stk1.Pop();
                    //        b = stk2.Pop();
                    //        a = stk2.Pop();
                    //        stk2.Push(Operation(oper, a, b));
                    //    }
                    //    stk1.Pop();
                    //}

                    //comment
                    //else if((top=='*'|| top == '/') && (i == '*' || i == '/'))
                    //{
                    //    oper = stk1.Pop();
                    //    b = Convert.ToInt16(stk2.Pop());
                    //    a = Convert.ToInt16(stk2.Pop());
                    //    ans = Operation(oper, a, b);
                    //    stk2.Push(int.Parse(ans.ToString()));
                    //    stk1.Push(i);
                    //    continue;
                    //}
                    //else if ((top == '*' || top == '/') && (i == '+' || i == '-'))
                    //{
                    //    oper = stk1.Pop();
                    //    b = Convert.ToInt16(stk2.Pop());
                    //    a = Convert.ToInt16(stk2.Pop());
                    //    ans = Operation(oper, a, b);
                    //    stk2.Push(int.Parse(ans.ToString()));
                    //    stk1.Push(i);
                    //    continue;
                    //}
                    //else if ((top == '+'|| top == '-') && (i == '+' || i == '-'))
                    //{
                    //    oper = stk1.Pop();
                    //    b = Convert.ToInt16(stk2.Pop());
                    //    a = Convert.ToInt16(stk2.Pop());
                    //    ans = Operation(oper, a, b);
                    //    stk2.Push(int.Parse(ans.ToString()));
                    //    stk1.Push(i);
                    //    continue;
                    //}
                    //else if ((top == '+'|| top == ('-')) && (i == '*' || i == '/'))
                    //{
                    //    stk1.Push(i);
                    //    continue;
                    //}
                    //comment end

            //        else
            //        {
            //            while (stk1.Count > 0 &&
            //                   stk1.Peek() != '(' &&
            //                   Precedence(stk1.Peek()) >= Precedence(i))
            //            {
            //                oper = stk1.Pop();
            //                b = stk2.Pop();
            //                a = stk2.Pop();
            //                stk2.Push(Operation(oper, a, b));
            //            }
            //            stk1.Push(i);
            //        }

            //    }
            //}
//            while (stk1.Count > 0)
//            {
//                oper = stk1.Pop();
//                b = stk2.Pop();
//                a = stk2.Pop();
//                stk2.Push(Operation(oper, a, b));
//            }
//            Console.WriteLine(stk2.Peek());
//        }
//        internal int Operation(char oper, int a, int b)
//        {
//            return oper switch
//            {
//                '+' => a + b,
//                '-' => a - b,
//                '*' => a * b,
//                '/' => a / b,// integer division
//                _ => throw new InvalidOperationException("Invalid operator"),
//            };
//        }
//        internal int Precedence(char op)
//        {
//            return op switch
//            {
//                '+' or '-' => 1,
//                '*' or '/' => 2,
//                _ => 0
//            };
//        }
//    }
//}
