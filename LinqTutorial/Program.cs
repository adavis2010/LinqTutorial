using System;
//NEED THIS USING STATEMENT WHEN USING LYNC
using System.Linq;
namespace LinqTutorial {
    class Program {
        static void Main(string[] args) {
            //1st exercise we did using Linq
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
                6469, 5237, 7988, 1240, 7585, 1458, 4339, 3120, 2976, 3659

        };
            //using Query Syntax (for numbers less than 5000)
            var lessthan5000 = from nbr in numbers
                               where nbr < 5000
                               orderby nbr
                               select nbr;

            //Method Syntax (for numbers less than 5000)
            var lessThan5000A = numbers.Where(nbr => nbr < 5000).OrderBy(nbr => nbr).ToList();


            //Query Syntax get numbers greater than or equal to 2500 and LTE 7500 EXERCISE 1
            var ex1= from nbr in numbers
                         where nbr >= 2500 && nbr <= 7500
                         orderby nbr
                         select nbr;

            //Use Method Syntax for EXERCISE 1

            var ex1a = numbers.Where(nbr => nbr <= 2500 && nbr <= 7500)
                .OrderBy(nbr => nbr).ToList();
                  

            //Query syntax less than 2000 and greater than 8000 sort by descending order EXERCISE 2
            var ex2 = from nbr in numbers
                       where nbr < 2000 || nbr > 8000
                       orderby nbr descending
                       select nbr;

            //Use Method Syntax for EXERCISE 2 (change variable)
            var ex2a = numbers.Where(nbr => nbr < 2000 || nbr > 8000)
            .OrderByDescending(nbr=>nbr).ToList();

            //Query Syntax nbrs between 1500 and 3000 or 6500 and 8500 EXERCISE 3
            var ex3 = from nbr in numbers
                       where (nbr > 1500 && nbr < 3000)||(nbr > 6500 && nbr < 8500)
                       orderby nbr 
                       select nbr;

            //Use Method Syntax on EXERCISE 3 (change variable)
          var ex3a = numbers.Where(nbr => (nbr > 1500 && nbr < 3000)||(nbr > 6500 && nbr > 8500))
                .OrderBy(nbr => nbr).ToList();

            //Query Syntax: sum the numbers between 1500 and 3000 or 6500 and 8500 EXERCISE 4(wrap whole query in () and them .Sum, add, subtract etc) changed variable name = var ex3aa
            var ex3aa = (from nbr in numbers
                         where (nbr > 1500 && nbr < 3000) || (nbr > 6500 && nbr < 8500)
                         orderby nbr
                         select nbr).Sum(nbr => nbr);
        }

    }
}
