using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace _3Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(',')
                .Where(x => x != ",")
                .Select(x => int.Parse(x)).ToArray();

            var test = ThreeSum(str);
            //foreach (var x in test)
            //{
            //    Console.WriteLine();
            //    foreach (var y in x)
            //    {
            //        Console.Write(y + ", ");
            //    }
            //}
        }

        static public IList<IList<int>> ThreeSum(int[] nums)
        {
            
            IList<IList<int>> lst = new List<IList<int>>(); 
            int i = 0;
            for (int j  = 1; j < nums.Length - 1; j++)
            {

                for (int k = j + 1; k < nums.Length; k++)
                {
                    if ((nums[i] + nums[j] + nums[k]) == 0)
                    {
                        lst.Add(new List<int>() { nums[i], nums[j], nums[k] });
                    }
                }
            }
            if (lst.Count > 1)
            {
                var result = DistinktMass(lst);
                return result;
            }
            return lst;
        }

        static private IList<IList<int>> DistinktMass(IList<IList<int>> nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < nums.Count - 1; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i].SequenceEqual(nums[j]))
                    {
                        continue;
                    }
                    else
                    {
                        result.Add(nums[i]);
                    }
                }
            }
            return result;
        }
    }
}