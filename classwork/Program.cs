using System;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.1");
            double number = 55.15;
            Console.WriteLine(number);

            Console.WriteLine("Task 1.2");
            double e = Math.E;
            Console.WriteLine(Math.Round(e,1)); 

            Console.WriteLine("Task 1.3");
            Console.Write(""); 
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели число " + num);

            Console.WriteLine("Task 1.4");
            Console.Write("Введите число: ");
            int number_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number_1 + " - вот такое число вы ввели");

            Console.WriteLine("Task 1.5");
            int x = 1, y = 13, z = 49;
            Console.WriteLine(x + " " + y + " " + z);

            Console.WriteLine("Task 1.6");
            int num_1 = 7, num_2 = 15, num_3 = 100;
            Console.WriteLine(num_1 + "  " + num_2 + "  " + num_3);

            Console.WriteLine("Task 1.7");
            Random r = new Random();
            int a11 = r.Next();
            int b11 = r.Next();
            int c11 = r.Next();
            Console.WriteLine(a11 + "  " + b11 + "  "+ c11);


            Console.WriteLine("Task 1.8");
            int rand_1 = r.Next();
            int rand_2 = r.Next();
            int rand_3 = r.Next();
            int rand_4 = r.Next();
            Console.WriteLine(rand_1 + " " + rand_2 + " " + rand_3 + " " + rand_4);

            Console.WriteLine("Task 1.9");
            int k = 50;
            int m = 10;
            Console.WriteLine(k + "\n" + m);

            Console.WriteLine("Task 1.10");
            int h = 5;
            int i = 10;
            int g = 21;
            Console.WriteLine(h + "\n" + i + "\n" + g);

            Console.WriteLine("Task 1.11");
            int l = r.Next();
            int o = r.Next();
            int u = r.Next();
            int t = r.Next();
            Console.WriteLine(l + "\n" + o + "\n" + u + "\n" + t);

            Console.WriteLine("Task 1.12");
            int one = 5;
            int two = 10;
            int three_3 = 7;
            Console.WriteLine(one + " " + two + "\n" + three_3 + " см");

            Console.WriteLine("Task 1.13");
            int n1, n2, n3;
            n1 = 2;
            n2 = 13;
            n3 = 17;
            Console.WriteLine(n1 + " кг " + "\n" + n2 + " " + n3);

            Console.WriteLine("Task 2.1 a");
            Console.Write("Enter the value of x: ");
            double valuex = Convert.ToDouble(Console.ReadLine());
            double valuey = 7 * valuex * valuex + 3 * valuex + 6;
            Console.WriteLine("The value of y = " + valuey);

            Console.WriteLine("Task 2.1 b");
            Console.Write("Enter the value of a: ");
            double value_a = Convert.ToDouble(Console.ReadLine());           
            double value_x = 12 * value_a * value_a + 7 * value_a + 12;
            Console.WriteLine("The value of x = " + value_x);

            Console.WriteLine("Task 2.2"); 
            Console.Write("Введите длину стороны квадрата: ");
            double side_length = Convert.ToDouble(Console.ReadLine());
            double square_perimeter = 4 * side_length;
            Console.WriteLine("Периметр квадрата: " + square_perimeter);

            Console.WriteLine("Task 2.3");
            Console.Write("Введите длину радиуса окружности: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double diameter = 2 * radius;
            Console.WriteLine("Диаметр окружности: " + diameter);
           
            Console.WriteLine("Task 2.4"); 
            double rEarth = 6350;
            Console.Write("Введите высоту над землей: ");
            double hor_height = Convert.ToDouble(Console.ReadLine());
            double horizon_distance = Math.Sqrt((rEarth + hor_height) * (rEarth + hor_height) - rEarth * rEarth);
            Console.WriteLine("Расстояние до линии горизонта: " + horizon_distance + " км.");

            Console.WriteLine("Task 2.5");
            Console.Write("Введите длину ребра куба: ");
            double cube_edge = Convert.ToDouble(Console.ReadLine());
            double cube_volume = Math.Pow(cube_edge, 3);
            double cube_surface = 6 * cube_edge * cube_edge;
            Console.WriteLine("Объем куба: " + cube_volume);
            Console.WriteLine("Площадь поверхности куба: " + cube_surface);
             
            Console.WriteLine("Task 2.6");
            Console.Write("Введите длину радиуса окружности: ");
            double circle_radius = Convert.ToDouble(Console.ReadLine());
            double circumference = 2 * Math.PI * circle_radius;
            double circle_area = Math.PI * circle_radius * circle_radius;
            Console.WriteLine("Длина окружности: " + circumference);
            Console.WriteLine("Площадь круга: " + circle_area);

            Console.WriteLine("Task 2.7");
            Console.Write("Введите первое число: ");
            int first_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int second_num = Convert.ToInt32(Console.ReadLine());
            int arithmetic_average = (first_num + second_num) / 2;
            int geometric_average = Convert.ToInt32(Math.Sqrt(first_num * second_num));
            Console.WriteLine("a)Среднее арифметическое: " + arithmetic_average);
            Console.WriteLine("б)Среднее геометрическое: " + geometric_average);

            Console.WriteLine("Task 2.8");
            Console.Write("Введите объем тела: ");
            double volume = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите массу тела: ");
            double mass = Convert.ToDouble(Console.ReadLine());
            double density = mass / volume;
            Console.WriteLine("Плотность материала тела: " + density);

            Console.WriteLine("Task 2.9");
            Console.Write("Введите количество жителей: ");
            double citizen = Convert.ToDouble(Console.ReadLine());
            Console.Write("Площадь территории: ");
            double territory = Convert.ToDouble(Console.ReadLine());
            double population_density = citizen / territory;
            Console.WriteLine("Плотность населения: " + population_density);

            Console.WriteLine("Task 2.10");
            Console.Write("");

            Console.WriteLine("Task 2.11");
            Console.Write("Введите длину первого катета: ");
            double first_cathetus = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второго катета: ");
            double second_cathetus = Convert.ToDouble(Console.ReadLine());
            double hypotenuse = Math.Sqrt(Math.Pow(first_cathetus, 2) + Math.Pow(second_cathetus, 2));
            Console.WriteLine("Длина гипотенузы: " + hypotenuse);

            Console.WriteLine("Task 2.12");
            Console.Write("Введите внешний радиус: ");
            double outer_radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите внутренний радиус: ");
            double inner_radius = Convert.ToDouble(Console.ReadLine());
            double ring_area = Math.PI * (Math.Pow(outer_radius, 2) - Math.Pow(inner_radius, 2));
            Console.WriteLine("Площадь кольца: " + ring_area);

            Console.WriteLine("Task 2.13");
            Console.Write("Введите длину первого катета: ");
            double cathetus_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второго катета: ");
            double cathetus_2 = Convert.ToDouble(Console.ReadLine());
            double triangle_hypotenuse = Math.Sqrt(Math.Pow(cathetus_1, 2) + Math.Pow(cathetus_2, 2));
            double triangle_perimeter_1 = cathetus_1 + cathetus_2 + triangle_hypotenuse;
            Console.WriteLine("Периметр прямоугольного треугольника: " + triangle_perimeter_1);

            Console.WriteLine("Task 2.13A");
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double mod_arithmetic = (Math.Abs(num1) + Math.Abs(num2))/2;
            double mod_geometric = Math.Sqrt(Math.Abs(num1) * Math.Abs(num2));
            Console.WriteLine("a)Среднее арифметическое модулей чисел: " + mod_arithmetic);
            Console.WriteLine("б)Среднее геометрическое модулей чисел: " + mod_geometric);

            Console.WriteLine("Task 2.14"); 
            Console.Write("Введите большее основание равнобедренной трапеции: ");
            double bigger_base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите меньшее основание равнобедренной трапеции: ");
            double smaller_base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту равнобедренной трапеции: ");
            double tr_height = Convert.ToDouble(Console.ReadLine());
            double one_side = (bigger_base - smaller_base) / 2;
            double tr_side = Math.Sqrt(tr_height * tr_height + one_side * one_side);
            double perimeter_tr1 = bigger_base + smaller_base + 2 * tr_side;
            Console.WriteLine("Периметр равнобедренной трапеции: " + perimeter_tr1);


            Console.WriteLine("Task 2.14A");
            Console.Write("Введите ширину прямоугольника: ");
            double rectangle_width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину прямоугольника: ");
            double rectangle_length = Convert.ToDouble(Console.ReadLine());
            double rectangle_perimeter = 2 * (rectangle_width + rectangle_length);
            double rectangle_diagonal = Math.Sqrt(Math.Pow(rectangle_length, 2) + Math.Pow(rectangle_width, 2));
            Console.WriteLine("Периметр прямоугольника: " + rectangle_perimeter);
            Console.WriteLine("Длина диагонали прямоугольника: " + rectangle_diagonal);

            Console.WriteLine("Task 2.15"); 
            Console.Write("Введите первое число: ");
            double num_one1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num_two2 = Convert.ToDouble(Console.ReadLine());
            if (num_two2 != 0)
            {
                double summ = num_one1 + num_two2;
                double subtract = num_one1 - num_two2;
                double mult = num_one1 * num_two2;
                double div = num_one1 / num_two2;
                Console.WriteLine("Сумма: " + summ + "\n" + "Разность: " + subtract + "\n" + "Произведение: " + mult + "\n" + "Деление: " + div);
             }else
            {
                Console.WriteLine("Число не может равняться нулю.");
            }
           

            Console.WriteLine("Task 2.16");
            Console.Write("Введите ширину параллелепипеда: ");
            double width_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину параллелепипеда: ");
            double length_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту параллелепипеда: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double par_volume = width_1 * length_1 * height;
            double par_side_area = 2 * height * (width_1 + length_1);
            Console.WriteLine("Объем прямоугольного параллелепипеда: " + par_volume );
            Console.WriteLine("Площадь боковой поверхности параллелепипеда: " + par_side_area);

            Console.WriteLine("Task 2.17");
            Console.WriteLine("Введите координаты первой точки.");
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки.");
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Расстояние между двумя точками на плоскости : " + distance );

            Console.WriteLine("Task 2.18");
            Console.WriteLine("Повторяет 2.14");

           
            
            Console.WriteLine("Task 2.20");
            Console.WriteLine("Введите координаты первой вершины.");
            Console.Write("x1 = ");
            double x_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины.");
            Console.Write("x2 = ");
            double x_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей вершины.");
            Console.Write("x3 = ");
            double x_3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3 = ");
            double y_3 = Convert.ToDouble(Console.ReadLine());
            double length__1 = Math.Sqrt((x_1 - x_2) * (x_1 - x_2) + (y_1 - y_2) * (y_1 - y_2));
            double length_2 = Math.Sqrt((x_1 - x_3) * (x_1 - x_3) + (y_1 - y_3) * (y_1 - y_3));
            double length_3 = Math.Sqrt((x_2 - x_3) * (x_2 - x_3) + (y_2 - y_3) * (y_2 - y_3));
            double triangle_perimeter = length__1 + length_2 + length_3;
            double p = triangle_perimeter / 2;
            //формула Герона
            double triangle_area = Math.Sqrt(p * (p - length__1) * (p - length_2) + (p - length_3));
            Console.WriteLine("Периметр треугольника: " + triangle_perimeter);
            Console.WriteLine("Площадь треугольника: " + triangle_area);

            /*
            Console.WriteLine("Task 2.21");
            Console.WriteLine("Введите координаты первой вершины.");
            Console.Write("x1 = ");
            double x__1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y__1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины.");
            Console.Write("x2 = ");
            double x__2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y__2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей вершины.");
            Console.Write("x3 = ");
            double x__3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3 = ");
            double y__3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты четвертой вершины.");
            Console.Write("x4 = ");
            double x__4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y4 = ");
            double y__4 = Convert.ToDouble(Console.ReadLine());
            double side_one = Math.Sqrt((x__1 - x__2) * (x__1 - x__2) + (y__1 - y__2) * (y__1 - y__2));
            double side_two = Math.Sqrt((x__2 - x__3) * (x__2 - x__3) + (y__2 - y__3) * (y__2 - y__3));
            double side_three = Math.Sqrt((x__3 - x__4) * (x__3 - x__4) + (y__3 - y__4) * (y__3 - y__4));
            double side_four = Math.Sqrt((x__4 - x__1) * (x__4 - x__1) + (y__4 - y__1) * (y__4 - y__1));
            double d1 = Math.Sqrt((x__1 - x__3) * (x__1 - x__3) + (y__1 - y__3) * (y__1 - y__3)); //диагональ
            double S1 = 
            */

            Console.WriteLine("Task 2.22");
            double sweets_price, cookie_price, apple_price, sweets_weight, cookie_weight, apple_weight;
            Console.Write("Введите стоимость 1 кг конфет: ");
            sweets_price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес купленных конфет: ");
            sweets_weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг печенья: ");
            cookie_price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес купленного печенья: ");
            cookie_weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг яблок: ");
            apple_price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес купленных яблок: ");
            apple_weight = Convert.ToDouble(Console.ReadLine());
            double total_price = sweets_price * sweets_weight + cookie_price * cookie_weight + apple_price * apple_weight;
            Console.WriteLine("Общая стоимость покупки: " + total_price);

            Console.WriteLine("Task 2.23");
            int monitor, system_unit, keyboard, mouse, N;
            Console.Write("Введите стоимость монитора: ");
            monitor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость системного блока: ");
            system_unit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость клавиатуры: ");
            keyboard = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость мыши: ");
            mouse = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество компьютеров: ");
            N = Convert.ToInt32(Console.ReadLine());
            int three = 3 * (monitor + system_unit + keyboard + mouse);
            int requested = N * (monitor + system_unit + keyboard + mouse);
            Console.WriteLine("Стоимость трёх компьютеров: " + three);
            Console.WriteLine("Стоимость " + N + " компьютеров: " + requested);

            

            Console.WriteLine("Task 2.27");
            Console.Write("");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = 1.8 * celsius + 32;
            double kelvin = celsius + 273.15;
            Console.WriteLine("Температура по шкале Фаренгейта: " + fahrenheit + "\n" + "Температура по шкале Кельвина: " + kelvin);

            Console.WriteLine("Task 2.28");
            double F = 450;
            double C = (F - 32) / 1.8;
            Console.WriteLine("Температура по шкале Цельсия: " + C);

            Console.WriteLine("Task 3.1");
            double first_var, second_var, swap;
            Console.Write("Введите значение первой переменной: ");
            first_var = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение второй переменной: ");
            second_var = Convert.ToDouble(Console.ReadLine());
            swap = first_var;
            first_var = second_var;
            second_var = swap;
            Console.WriteLine("Значение первой переменной: " + first_var + ". Значение второй переменной: " + second_var);

            Console.WriteLine("Task 3.2a");
            double var_a, var_b, var_c, swap2;
            Console.Write("Введите значение первой переменной: ");
            var_a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение второй переменной: ");
            var_b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение третьей переменной: ");
            var_c = Convert.ToDouble(Console.ReadLine());
            swap2 = var_a;
            var_a = var_b;
            var_b = var_c;
            var_c = swap2;
            Console.WriteLine("a = " + var_a + ", b = " + var_b + ", c = " + var_c);

            Console.WriteLine("Task 3.2b");
            double var_a1, var_b1, var_c1, swap3;
            Console.Write("Введите значение первой переменной: ");
            var_a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение второй переменной: ");
            var_b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение третьей переменной: ");
            var_c1 = Convert.ToDouble(Console.ReadLine());
            swap3 = var_a1;
            var_a1 = var_c1;
            var_c1 = var_b1;
            var_b1 = swap3;
            Console.WriteLine("a = " + var_a1 + ", b = " + var_b1 + ", c = " + var_c1);

            Console.WriteLine("Task 3.3a");
            int a, R;
            Console.Write("Введите число: ");
            a = Convert.ToInt32(Console.ReadLine());
            R = a * a;
            R = R * R;
            Console.WriteLine("a4 за две операции: " + R);

            Console.WriteLine("Task 3.3b");
            int a1, R1;
            Console.Write("Введите число: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            R1 = a1 * a1;
            R1 = R1 * a1;
            R1 = R1 * R1;
            Console.WriteLine("a6 за три операции: " + R1);

            Console.WriteLine("Task 3.3v");
            int a2, R2;
            Console.Write("Введите число: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            R2 = a2 * a2;
            R2 = R2 * a2;
            R2 = R2 * R2;
            R2 = R2 * a2;
            Console.WriteLine("a7 за четыре операции: " + R2);

            Console.WriteLine("Task 3.3v");
            int a3, R3;
            Console.Write("Введите число: ");
            a3 = Convert.ToInt32(Console.ReadLine());
            R3 = a3 * a3;
            R3 = R3 * R3;
            R3 = R3 * R3;
            Console.WriteLine("a8 за три операции: " + R3);














































        }




    }

}
