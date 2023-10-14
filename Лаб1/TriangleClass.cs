using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TriangleLAB1Name
{
    public class TriangleClass
    {
        public static (string, float[], float[], float[]) GoTriangle(string a_Parameter, string b_Parameter, string c_Parameter)
        {
            try
            {
                var a = Regex.IsMatch(a_Parameter, @"^[А-Яа-я0-9!@#\$%\^&\*\(\)_\+`~\-=\[\]\{\}\|\\:\;,\.<>\?\/]+$");
                var b = Regex.IsMatch(b_Parameter, @"^[А-Яа-я0-9!@#\$%\^&\*\(\)_\+`~\-=\[\]\{\}\|\\:\;,\.<>\?\/]+$");
                var c = Regex.IsMatch(c_Parameter, @"^[А-Яа-я0-9!@#\$%\^&\*\(\)_\+`~\-=\[\]\{\}\|\\:\;,\.<>\?\/]+$");



                if (a_Parameter == "" || b_Parameter == "" || c_Parameter == "")
                {
                    return("не треугольник", null, null,null);
                }
                else if ( a == false || b == false || c == false)
                {
                    return ("не треугольник", null, null, null);
                }
                else
                {
                    float A = float.Parse((a_Parameter)); // конвертируем длины треугольников
                    float B = float.Parse(b_Parameter); // конвертируем длины треугольников
                    float C = float.Parse(c_Parameter); // конвертируем длины треугольников
                                                        //(a_Parameter == "" || b_Parameter == "" || c_Parameter == "")
                    if (A <= 0 || B <= 0 || C <= 0)
                    {
                        float[] xyA = new float[] { -2, -2 };
                        float[] xyB = new float[] { -2, -2 };
                        float[] xyC = new float[] { -2, -2 };
                        string msg = $" \n\nA: ({Convert.ToInt32(xyA[0])}; {xyA[1]})\nB: ({Convert.ToInt32(xyB[0])}; {xyB[1]})\nC: ({Convert.ToInt32(xyC[0])}; {xyC[1]})\n";
                        Log.Information(msg);
                        return ("не треугольник", xyA, xyB, xyC);
                    }

                    // Проверка на: Являются ли введённые данные треугольником
                    if (A + B >= C && A + C >= B && B + C >= A)
                    {
                        string type = ""; // Переменная для хранения названия типа треугольника


                        // ↓↓↓↓↓↓↓↓↓↓↓ Определение типа треугольника ↓↓↓↓↓↓↓↓↓↓↓
                        if (A == C && B == A && B == C) type = "Равносторонний";
                        else if (A == B || B == C || A == C) type = "Равнобедренный";
                        else type = "Разносторонний";



                        float[] xyA = new float[] { 0, 0 }; // первая вершина треугольника лежит в точке (0; 0)
                        float[] xyB = new float[] { C, 0 }; // следующая по оси ординат находится в точке, а по абциссе отходит от начала координат на длину третьей стороны

                        float cosA = (B * B + C * C - A * A) / (2 * B * C); // для получения третьей координаты по формуле через длины вычислим косинус угла, лежащего между первой и второй сторонами
                        float sinA = (float)Math.Sqrt(1 - cosA * cosA); // по формуле вычислим синус
                        float height = B * sinA; // также по формуле находим высоту по формуле синуса и прилежащей длины

                        float temp = (C * C - B * B + A * A) / (2 * A); // находим координаты третьей вершины

                        float[] xyC = new float[] { temp, (float)Math.Sqrt(height * height - temp * temp) };

                        if (Math.Max(xyA[0], Math.Max(xyA[1], Math.Max(xyB[0], Math.Max(xyB[1], Math.Max(xyC[0], xyC[1]))))) > 80) // если значение координат выходит за пределы
                        { // определённого значения, масштабируем
                            float scale = 100 / Math.Max(xyB[0], Math.Max(xyC[0], xyC[1])); // условно, 100 процентов делим на максимальную координату
                            xyA[0] *= scale;
                            xyA[1] *= scale; // домножаем, чтобы масштабировать
                            xyB[0] *= scale;
                            xyB[1] *= scale;
                            xyC[0] *= scale;
                            xyC[1] *= scale;
                        }

                        string msg = $"{type}\n\nA: ({(int)xyA[0]}; {(int)xyA[1]})\nB: ({xyB[0]}; {(int)xyB[1]})\nC: ({(int)xyC[0]}; {(int)xyC[1]})\n";
                        Log.Information(msg);
                        return (type, xyA, xyB, xyC); // возвращаем значения, логируем
                    }
                    else
                    {
                        float[] xy1 = new float[] { -1, -1 };
                        float[] xy2 = new float[] { -1, -1 };
                        float[] xy3 = new float[] { -1, -1 };
                        string msg = $" Не треугольник\nA: ({(int)xy1[0]}; {(int)xy1[1]})\nB: ({(int)xy2[0]}; {(int)xy2[1]})\nC: ({(int)xy3[0]}; {(int)xy3[1]})\n";
                        Log.Information(msg);
                        return ("не треугольник", xy1, xy2, xy3);
                    }
                }

            }
            catch (Exception ex) // случай, при котором данные не могут быть корректно конвертированы
            {
                float[] xy1 = new float[] { -2, -2 };
                float[] xy2 = new float[] { -2, -2 };
                float[] xy3 = new float[] { -2, -2 };
                string msg = $" \n\nA: ({(int)xy1[0]}; {(int)xy1[1]})\nB: ({(int)xy2[0]}; {(int)xy2[1]})\nC: ({(int)xy3[0]}; {(int)xy3[1]})\n";
                Log.Error(ex, msg);
                return ("", xy1, xy2, xy3);
            }
        }


        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Введите стороны треугольника ↓\n");
                Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("C:\\Users\\New\\source\\repos\\Лаб1\\Лаб1\\TestLab.txt")
                .CreateLogger(); // создание логгера

                Console.Write("Сторона A: \t");
                string A = Console.ReadLine(); // ввод данных
                Console.Write("Сторона B: \t");
                string B = Console.ReadLine(); // ввод данных
                Console.Write("Сторона C: \t");
                string C = Console.ReadLine(); // ввод данных
                Console.WriteLine();

                string type;


                // ↓переменные для хранения координат↓
                float[] Coordinates_A = new float[2]; 
                float[] Coordinates_B = new float[2];
                float[] Coordinates_C = new float[2];

                (type, Coordinates_A, Coordinates_B, Coordinates_C) = GoTriangle(A, B, C); 
                                                                 
            Log.CloseAndFlush(); // закрывается логгер

                Console.WriteLine("End");
            }
        }
    }
}