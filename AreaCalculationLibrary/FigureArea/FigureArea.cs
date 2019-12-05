using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLibrary.FigureArea
{
    public class FigureArea
    {
        /// <summary>
        /// Расчет площади круга
        /// </summary>
        /// <param name="circleRadius">Радиус круга</param>
        /// <returns></returns>
        public double CircleAreaSearch(double circleRadius)
        {
            double result = Math.Round(Math.PI * Math.Pow(circleRadius, 2), 2);//Формула для вычисления площади круга
            return result;//Возвращаем результат
        }

        /// <summary>
        /// Расчёт площади треугольника по трем сторонам
        /// </summary>
        /// <param name="firstSide">Длинна первой стороны</param>
        /// <param name="secondSide">Длинна второй стороны</param>
        /// <param name="thirdSide">Длинна третьей стороны</param>
        /// <returns></returns>
        public double TriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            double p = TrianglePerimeter(firstSide, secondSide, thirdSide);//Расчитываем полупериметр треугольника
            double S = Math.Round(Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide)),2);//Формула для вычисления площади треугольника
            return S;//Возвращаем результат
        }

        /// <summary>
        /// Расчёт площади треугольника по двум сторонам и одному углу
        /// </summary>
        /// <param name="firstSide">Длинна первой стороны</param>
        /// <param name="secondSide">Длинна второй стороны</param>
        /// <param name="angle">Угол треугольника</param>
        /// <returns></returns>
        public double TriangleArea(double firstSide, double secondSide, int angle)
        {
            double S;//Площадь треугольника

            //Проверка на то, является ли треугольник прямоугольным
            if (angle == 90)
                S = 0.5 * firstSide * secondSide;//Формула для вычисления площади прямоугольного треугольника
            else
            {
                double sinAngle = Math.Round(Math.Sin(Math.PI * angle / 180), 1);//Вычисляем sin угла
                S = 0.5 * firstSide * secondSide * sinAngle;//Формула для вычисления площади треугольника
            }

            return S;//Возвращаем результат
        }

        /// <summary>
        /// Расчёт полупериметра треугольника
        /// </summary>
        /// <param name="firstSide">Длинна первой стороны</param>
        /// <param name="secondSide">Длинна второй стороны</param>
        /// <param name="thirdSide">Длинна третьей стороны</param>
        /// <returns></returns>
        private double TrianglePerimeter(double firstSide, double secondSide, double thirdSide)
        {
            double result = (firstSide + secondSide + thirdSide) / 2;//Формула для расчёта полупериметра треугольника
            return result;//Возвращаем результат
        }
    }
}
