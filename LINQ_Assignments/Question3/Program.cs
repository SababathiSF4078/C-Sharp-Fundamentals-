using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can get the trainee details from the GetTraineeDetails() method in TraineeData class
            Console.WriteLine("Enter Menu Number");
            int option = Convert.ToInt32(Console.ReadLine());
            TraineeDetails obj = new TraineeDetails();
            TraineeData ob1 = new TraineeData();
            List<TraineeDetails> b = ob1.GetTraineeDetails();
            

            switch(option)
            {
                case 1:
                    {
                        IEnumerable<string> result=from trainee in b select trainee.TraineeId;
                        foreach(string id in result)
                        {
                            Console.WriteLine(id);
                        }
                       
                        break;
                    }
                case 2:
                    {
                        IEnumerable<string> result=(from trainee in b select trainee.TraineeId).Take(3);
                        foreach(string id in result)
                        {
                            Console.WriteLine(id);
                        }
                        
                        break;
                    }
                case 3:
                    {
                        IEnumerable<string> result=(from trainee in b select trainee.TraineeId).Skip(3);
                        foreach(string id in result)
                        {
                            Console.WriteLine(id);
                        }
                        break;
                    }
                case 4:
                    {
                        IEnumerable<string> result=(from trainee in b select trainee.TraineeId);
                        Console.WriteLine(result.Count());
                        break;
                        
                    }
                case 5:
                    {
                        IEnumerable<string> result=(from trainee in b where trainee.YearPassedOut>=2019 select trainee.TraineeName);
                        foreach(string id in result)
                        {
                            Console.WriteLine(id);
                        }
                        break; 

                    }
                case 6:
                    {
                        IEnumerable<TraineeDetails> result=b.OrderBy(c => c.TraineeName);
                        foreach(TraineeDetails id in result)
                        {
                            Console.WriteLine($"{id.TraineeId} --- {id.TraineeName}");
                        }
                        break;
                    }
                case 7:
                {
                    IEnumerable<TraineeDetails> result=b.OrderBy(c => c.ScoreDetails);
                    foreach(TraineeDetails id in result)
                    {
                        Console.WriteLine($"{id.TraineeName}");
                    }
                    break;
                }
                case 8:
                {
                    IEnumerable<int> years=(from trainee in b select trainee.YearPassedOut).Distinct();
                    foreach(int year in years)
                    {
                        Console.WriteLine(year);
                    }
                    break;
                    
                }
                case 9:
                {
                    Console.WriteLine("Enter the trainee id: ");
                    string traineeID=Console.ReadLine().ToUpper();

                    IEnumerable<int> marks=from trainee in b where trainee.TraineeId == traineeID select trainee.TotalScore;

                    if(marks.Count()==0)
                    {
                        Console.WriteLine("Invalid ID");
                    }
                    else
                    {
                        foreach(int mark in marks)
                        {
                            Console.WriteLine(mark);
                        }
                    }
                    break;

                }
                case 10:
                {
                    TraineeDetails trainee=b.First();
                    Console.WriteLine(trainee.TraineeId + "----" +trainee.TraineeName);
                    break;
                }
                case 11:
                {
                    TraineeDetails trainee=b.Last();
                    Console.WriteLine(trainee.TraineeId + "----" +trainee.TraineeName);
                    break;
                }
                case 12:
                {
                    IEnumerable<TraineeDetails> result = from trainee in b select trainee;
                    foreach(TraineeDetails trainee in result)
                    {
                        Console.WriteLine(trainee.TotalScore);
                    }
                    break;
                }
                case 13:
                {
                    int maximumScore=(from trainee in b select trainee.TotalScore).Max();
                    Console.WriteLine(maximumScore);
                    break;
                }
                case 14:
                {
                    int minimumScore=(from trainee in b select trainee.TotalScore).Min();
                    Console.WriteLine(minimumScore);
                    break;
                }
                case 15:
                {
                    double averageScore=(from trainee in b select trainee.TotalScore).Average();
                    Console.WriteLine(averageScore);
                    break;
                }
                case 16:
                {
                    bool result=(from trainee in b  select trainee).Any(trainee =>  trainee.TotalScore>40);
                    Console.WriteLine(result);
                    break;
                }
                case 17:
                {
                    bool result=(from trainee in b  select trainee).All(trainee =>  trainee.TotalScore>20);
                    Console.WriteLine(result);
                    break;
                }
                case 18:
                {
                    IEnumerable<TraineeDetails> result=(from trainee in b select trainee).OrderBy(trainee => trainee.TraineeName).OrderBy(trainee => trainee.TraineeId);
                    foreach(TraineeDetails trainee in result)
                    {
                        Console.WriteLine($"{trainee.TraineeId} --- {trainee.TraineeName}");
                    }
                    break;
                }

             
            }
           
        }
    }
}
