using System;
struct Books
{
    public string teacher;
    public string subject;
    public int book_id;
}

namespace StructDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books book1;
                Books book2;
            book1.subject = "EGovernance";
            book1.teacher = "Anku";
            book1.book_id = 101;

            book2.subject = "Compiler Design";
            book2.teacher = "Bhim";
            book2.book_id = 102;


            Console.WriteLine("Book 1 subject :{0}", book1.subject);
            Console.WriteLine("Book 1 teacher :{0}", book1.teacher);
            Console.WriteLine("Book 1 book_id :{0}", book1.book_id);

            Console.WriteLine("Book 2 subject :{0}", book2.subject);
            Console.WriteLine("Book 2 teacher :{0}", book2.teacher);
            Console.WriteLine("Book 2 book_id :{0}", book2.book_id);

            Console.ReadLine();
        }
    }
}
