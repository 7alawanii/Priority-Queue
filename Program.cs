using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Heap heap = new Heap();
            int Max_Size;
            Console.Write("Please Enter The Maximum Size Of The Queue :  ");
            Max_Size = Convert.ToInt32(Console.ReadLine());
            Node[] Heap_Array=new Node[Max_Size];
         int size;
         heap.Current_Size=0;
            int choice = 0;
            Boolean flag = true;
        Console.Write("Please Enter The Size Of The Queue :  ");
            size = Convert.ToInt32(Console.ReadLine());
            Node temp;
        int v, p, o;
            for (int i = 0; i < size; i++)
            {
                o = i + 1;
                Console.Write("Please Enter The Value Of Node #" + o + " :  ");
                v = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please Enter The Priority Of Node #"+ o +" :  ");
                p = Convert.ToInt32(Console.ReadLine());
                temp = new Node(v, p, o);
                Heap_Array[i]=temp;
                heap.Current_Size++;
            }
            heap.Build_Max_Heap(Heap_Array, size);
            Console.WriteLine("Please Choose An Operation  : ");
            Console.WriteLine("   1) Enqueue   2) Dequeue   3) Print The Priority Queue   4) End");
            while (flag)
            {
                Console.Write("Operation Number :  ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    if (heap.Current_Size == Max_Size)
                    {
                        Console.WriteLine(" *** The Queue Is Full.");
                    }
                    else
                    {
                        Console.Write("Please Enter The Value Of The Node :  ");
                        v = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please Enter The Priority Of The Node :  ");
                        p = Convert.ToInt32(Console.ReadLine());
                        heap.enqueue(Heap_Array, v, p);
                        size = heap.Current_Size;
                    }
                }
                else if (choice == 2)
                {
                    if (heap.Current_Size == 0)
                    {
                        Console.WriteLine(" *** The Queue Is Empty.");
                    }
                    else
                    {
                        temp = heap.dequeue(Heap_Array);
                        Console.WriteLine("The Value Of The Highest Priority Node = " + temp.value + " With Priority = " + temp.priority);
                    }
                }
                else if (choice == 3)
                {
                    if (heap.Current_Size == 0)
                    {
                        Console.WriteLine(" *** The Queue Is Empty.");
                    }
                    else
                    {
                        Console.WriteLine("Node # ----->> Value ~~ Priority");
                        for (int i = 0; i < size; i++)
                        {
                            Node t = heap.dequeue(Heap_Array);
                            Console.WriteLine("  # " + (i + 1) + "  ----->>   " + t.value + "   ~~   " + t.priority);
                        }
                    }
                }
                else if (choice == 4)
                {
                    flag = false;
                }
                else
                    Console.WriteLine("Please Enter A Valid Number Of An Operation.");
            }
            Console.ReadLine();
        }
    }

}
