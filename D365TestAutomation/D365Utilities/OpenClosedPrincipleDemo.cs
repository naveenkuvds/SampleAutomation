using System;
using System.Collections.Generic;
using System.Text;

namespace D365Utilities
{
    /// <summary>
    /// Color of the product
    /// </summary>
    public enum Color
    {
        Red,Blue,Green,Yellow,Black
    }

    public enum Size
    {
        Small, Medium, Large, ExtraLarge
    }


    public class Product
    {
        public string Name;
        public Color color;
        public Size size;

        public Product(string name, Color clr, Size sz)
        {

        }
    }

    public class ProductFilter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var item in products)
            {
                if (item.color == color)
                    yield return item;
            }
        }
    }

    public class ProductFilterBySize
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var item in products)
            {
                if (item.size == size)
                    yield return item;
            }
        }
    }

    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> products, ISpecification<T> spec);
    }


    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> spec)
        {
            foreach (var item in products)
            {

                if (spec.IsSatisfied(item))
                    yield return item;
            }
        }
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product prod)
        {
            return prod.color == color;
        }
    }

    public class OpenClosedPrincipleDemo
    {
        
    }
}
