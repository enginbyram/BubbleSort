using System;

class BubbleSort {
    static void Main(string[] args) {

        // Create the array first for sorting
        Console.WriteLine("Randomizing the list..");
        var rnd = new Random();
        int[] sortList = new int[100];

        for(int i = 0;i<sortList.Length; i++) {
            sortList[i] = rnd.Next(0,100);
            Console.WriteLine($"Integer of array index {i} is {sortList[i]}");
        }

        Console.WriteLine($"UNSORTED ARRAY = {string.Join(",", sortList)}");

        // Bubble Sorting algorithm
        // in first loop, we loop all elements
        for(int n=0;n<sortList.Length - 1;n++) {
            // Then compare adjacent element
            for(int j=0;j<sortList.Length - n - 1;j++) {
                // here, we swap if element is bigger than the adjacent integer
                if(sortList[j]>sortList[j + 1]) {
                    Console.WriteLine($"Index {j} is bigger than adjacent index, sorting!");
                    int tempInt = sortList[j];
                    sortList[j] = sortList[j + 1];
                    sortList[j + 1] = tempInt;
                }
            }
        }

        Console.WriteLine($"SORTED ARRAY = {string.Join(",", sortList)}");


    }
}