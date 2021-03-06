﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    public partial class Exam
    {
        bool ITake.Take()
        {
            Console.WriteLine("Экзамен сдан");
            return true;
        }
    }

    class Program/*Класс является ссылочным типом, а структура значимым, структура не поддерживает наследование
Структуры не могут содержать конструкторов без параметров.
Структуры нельзя наследовать, модификатор доступа поля структуры не может быть protected.*/
    {
        struct st
        {
            public int number;
            public string quest;
            public st(int a, string c)
            {
                number = a;
                quest = c;
            }
        }
        enum mark
        {
            F = 1,
            D,
            C,
            B,
            A
        }
        static void Main(string[] args)
        {
            st st1 = new st(1, "вопроссс");
            Console.WriteLine("Вопрос номер " +  st1.number);
            Console.WriteLine(st1.quest);
            mark A = mark.A;
            if((int)A == 5)
                Console.WriteLine("A = 5");
            Session s1 = new Session();
            Exam ex1 = new Exam();
            ex1.Subject = "Math";
            Question q1 = new Question();
            q1.Text = "Do you know Pifagor?";
            ex1.Questions.Add(q1);
            Test t1 = new Test();
            t1.Subject = "English";
            Question q2 = new Question();
            q2.Text = "How is your english?";
            t1.Questions.Add(q2);
            Question q3 = new Question();
            q3.Text = "Is it you?";
            t1.Questions.Add(q3);
            Exam ex2 = new Exam();
            ex2.Subject = "PE";
            Question q4 = new Question();
            q4.Text = "Do you like sport?";
            ex2.Questions.Add(q4);
            Question q5 = new Question();
            q5.Text = "Where were the last Olimpic Games?";
            ex2.Questions.Add(q5);

            s1.AddExam(ex1);
            s1.AddExam(ex2);
            s1.AddTest(t1);
            SessionController controller = new SessionController(s1);
            controller.GetChechoutCount();
            controller.GetExamsCountBySubject("Math");
            controller.GetTestCountByQuestionCount(2);

            FinalExam Fe = new FinalExam();
            //Fe.ToString();

            try
            {
                Question q6 = new Question();
                q6.Text = "";
                s1.AddExam(ex1);
                s1.AddExam(ex1);
                s1.AddExam(ex1);
                // s1.AddExam(ex1);

                Exam ex3 = new Exam();
                ex3.Subject = "OOP";
               // ex3.ToString();

               /* int i = 0;
                //Console.WriteLine(1/i);

                int[] k = { 5, 3, 2, 6 };
                while (k[i] != 0)
                {
                    Console.WriteLine(k[i]);
                    i++;
                }

                */

                Question q = null;
                //q.Text = string.Empty;
            }

            catch (QuestionException e)
            {
                Console.WriteLine(e);
            }

            catch (SessionException e)
            {
                Console.WriteLine(e);
            }
            catch (ExamException e)
            {
                Console.WriteLine(e);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0 !!!\n");
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }

            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                Console.WriteLine("Блоки try-catch пройдены.");
            }

            /*Checkout ex1 = new Exam();                       //5 lab
            ex1.Take();
            ITake ex2 = (ITake)ex1;
            ex2.Take();


            var finalExam = new FinalExam();

            if (finalExam is Checkout)
            {
                Console.WriteLine("Exam is Checkout!");
            }
            else
            {
                Console.WriteLine("Exam is not Checkout");
            }

            finalExam.GetTypeName();

            var exam = finalExam as Exam;//создали ссылку ссылающуюся на объект преобразующийся в экзам

            exam.GetTypeName();


            Console.WriteLine("---------- 6 ----------");

            List<Checkout> list = new List<Checkout>();
            var ex = new Exam();
            var fex = new FinalExam();
            var test = new Test();
            list.Add(ex);
            list.Add(fex);
            list.Add(test);

            var printer = new Printer();

            foreach (var item in list)
            {
                printer.IAmPrinting(item);
            }*/
            
            Console.ReadKey();
        }
    }
}
