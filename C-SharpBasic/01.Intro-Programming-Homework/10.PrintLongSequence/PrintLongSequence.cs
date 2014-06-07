using System;




class Program
{
    static void Main()
    {
        {
            int positiveMember = 2;
            int negativeMember = -3;

            Console.Write(positiveMember + ", ");
            Console.Write(negativeMember + ", ");

            for (int i = 0; i < 498; i++)
            {
                Console.Write((positiveMember += 2) + ", ");
                Console.Write((negativeMember -= 2) + ", ");
            }

            Console.Write((positiveMember += 2) + ", ");
            Console.Write(negativeMember -= 2);

            Console.Read();

        }
    }


}