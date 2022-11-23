using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTask_Sample
{
          internal class Program
          {
                    static async Task Main(string[] args)
                    {
                              _= Method1();
                              await Method2();
                              _ = Method3();


                              

                              Console.ReadKey();
                    }


                    async Task m1()
                    {
                              Thread.Sleep(8000);
                              Console.WriteLine("School Started");
                    }

                    async Task m2()
                    {
                              Thread.Sleep(3000);
                              Console.WriteLine("School Started");
                    }

                    async Task m3()
                    {
                              Thread.Sleep(2000);
                              Console.WriteLine("School Started");
                    }


                    public static async Task Method1()
                    {
                              await Task.Run(() =>
                              {
                                        Thread.Sleep(8000);
                                        Console.WriteLine("School Started");
                              });
                    }


                    public static async Task Method2()
                    {
                              await Task.Run(() =>
                              {
                                        Thread.Sleep(3000);
                                        Console.WriteLine("Taught class 12");
                              });


                    }

                    public static async Task Method3()
                    {
                              await Task.Run(() =>
                              {
                                        Thread.Sleep(2000);
                                        Console.WriteLine("Taught class 11");
                              });


                    }
          }
}