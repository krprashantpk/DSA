using DSA.Algorithms.Sorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSA.Algorithms.UnitTesting.Sorts
{
    public class BubbleSortAlgorithmTest
    {

        [Theory]
        [InlineData(new int[] { 10 }, new int[] { 10 })]
        [InlineData(new int[] { 10, 10, 10 }, new int[] { 10, 10, 10 })]
        [InlineData(new int[] { -10, 1, 10 }, new int[] { -10, 1, 10 })]
        [InlineData(new int[] { -10, 1, -20 }, new int[] { -20, -10, 1 })]
        [InlineData(new int[] { 10, 5, 12, 19, 1, 5 }, new int[] { 1, 5, 5, 10, 12, 19 })]

        public void WhenIntInputIsValidArrayShouldBeSorted(int[] array, int[] sort)
        {
            array.BubbleOrderBy();
            Assert.Equal(sort, array);
        }


        [Theory]
        [InlineData(new int[] { 10 }, new int[] { 10 })]
        [InlineData(new int[] { 10, 10, 10 }, new int[] { 10, 10, 10 })]
        [InlineData(new int[] { -10, 1, 10 }, new int[] { 10, 1, -10 })]
        [InlineData(new int[] { -10, 1, -20 }, new int[] { 1 ,-10, -20})]
        [InlineData(new int[] { 10, 5, 12, 19, 1, 5 }, new int[] { 19, 12, 10, 5, 5, 1 })]
        public void WhenIntInputIsValidArrayShouldOrderByDescending(int[] array, int[] sort)
        {
            array.BubbleOrderByDescending();
            Assert.Equal(sort, array);
        }

        [Theory]
        [InlineData(new string[] { "a" }, new string[] { "a" })]
        [InlineData(new string[] { "a", "a", "a" }, new string[] { "a", "a", "a" })]
        [InlineData(new string[] { "z", "a", "c" }, new string[] { "a", "c", "z"})]
        [InlineData(new string[] { "az","ab","aza" }, new string[] { "ab", "az", "aza"})]

        public void WhenStringInputIsValidArrayShouldBeSorted(string[] array, string[] sort)
        {
            
            array.BubbleOrderBy();
            Assert.Equal(sort, array);
        }

        [Theory]
        [InlineData(new string[] { "a" }, new string[] { "a" })]
        [InlineData(new string[] { "a", "a", "a" }, new string[] { "a", "a", "a" })]
        [InlineData(new string[] { "z", "a", "c" }, new string[] { "z", "c", "a" })]
        [InlineData(new string[] { "az", "ab", "aza" }, new string[] { "aza" , "az", "ab"})]

        public void WhenStringInputIsValidArrayShouldOrderByDescending(string[] array, string[] sort)
        {

            array.BubbleOrderByDescending();
            Assert.Equal(sort, array);
        }

        [Fact]
        public void WhenInputIsNullAgrumentNullReferenceExceptionShouldBeThrown()
        {
            int[] array = null;
            Assert.Throws<ArgumentNullException>(() => array.BubbleOrderBy());
        }
    }
}
