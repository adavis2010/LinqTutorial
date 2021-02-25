using System;
//NEED THIS USING STATEMENT WHEN USING LYNC
using System.Linq;
namespace LinqTutorial {
    class Program {
        static void Main(string[] args) {

            var numbers = new int[] {
                8927, 2150, 2883, 2221, 3643, 4126, 5256, 9275, 7016, 1169,
                2681, 3087, 8256, 8125, 6865, 9366, 9547, 6634, 4739, 7914,
                9636, 8905, 9553, 4122, 8553, 9658, 8406, 8915, 7426, 7525,
                2279, 2724, 7744, 5838, 2630, 1483, 7161, 4514, 9937, 9453,
                3173, 5348, 3380, 4891, 5079, 8044, 5584, 6619, 8953, 4438,
                2543, 3843, 7468, 4139, 1426, 9309, 4631, 7133, 2527, 7507,
                2196, 2993, 3333, 9427, 3895, 3532, 8503, 4874, 2459, 5657,
                3086, 4653, 2396, 7749, 9524, 3291, 1895, 8809, 6948, 7992,
                3187, 4512, 1318, 6572, 9904, 2175, 6726, 9956, 3943, 3190,

            };
            //using Query Syntax (for numbers less than 5000)
            var lessthan5000 = from nbr in numbers
                               where nbr < 5000
                               orderby nbr
                               select nbr;

        }
    }
}
