using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue
{
    public class Heap
    {
       public int Current_Size;
        private void Swap(Node[] array,int i, int j)
        {
            Node temp =new Node(array[i].value,array[i].priority,array[i].order);
            array[i] = array[j];
            array[j] = temp;
        }
        public void Max_Heapify(Node[] array, int heapindex)
        {
            int largest=0;
            int length = Current_Size;
            int Right_Child = (heapindex*2)+2;
            int Left_Child = (heapindex*2)+1;
            if (Left_Child < length && array[Left_Child].priority > array[heapindex].priority)
                largest = Left_Child;
            else
                largest = heapindex;
            if (Right_Child < length && array[Right_Child].priority > array[largest].priority)
                largest = Right_Child;
            if (Left_Child < length && array[Left_Child].priority == array[heapindex].priority && array[Left_Child].order < array[heapindex].order)
                largest = Left_Child;
            if (Right_Child < length && array[Right_Child].priority == array[largest].priority && array[Right_Child].order < array[largest].order)
                largest = Right_Child;
            if (largest != heapindex)
            { 
                Swap(array,heapindex, largest);
                Max_Heapify(array, largest);
            }
        }
        /*public void Heap_Sort(Node[] array,int size)
        {
            Build_Max_Heap(array, size);
            int temp = Current_Size;
            for (int i = 0; i < temp - 1; i++)
            {
                Swap(array,,)
            }
            Current_Size = temp;

        }*/
        public void Build_Max_Heap(Node[] array,int size)
        {
            int newsize = size - 1;
            for (int i = (newsize /2); i >= 0; i--)
            {
                Max_Heapify(array,i);
            }
        }
        public void enqueue(Node[] array,int v,int p)
        { 
            Node n = new Node(v, p, Current_Size+1);
            array[Current_Size] = n;
            Current_Size++;
           Build_Max_Heap(array, Current_Size);
        }
        public Node dequeue(Node[] array)
        { 
            
            Node root = array[0];
            Current_Size--;
            array[0] = array[Current_Size];
            Build_Max_Heap(array, Current_Size);
            Max_Heapify(array, 0);
            return root;
        }
    }
}
