using System;

namespace CS {
    class Arrays {
        static void Main(string[] args) {
            int[] nums = {1,2,3,4,5,73,4,45,90};

            for(int i =0; i < nums.Length; i++) {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine("\n"+nums);
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Mark";
        }
    }
}