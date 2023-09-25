using System;

namespace project
    {
        class Program
        {
        static int[] gradesMath = new int[1];
        static int[] gradesUkr = new int[1];
        static int[] gradesEng = new int[1];
        static int[] gradesHist = new int[1];

        static void Main(string[] args)
        {
            ConsoleMenu(gradesEng, gradesHist, gradesMath, gradesUkr);
        }

        private static void ConsoleMenu(int[] gradesEng, int[] gradesHist, int[] gradesMath, int[] gradesUkr)
        {
            MainMenu choice;
            while (true)
            {
                Console.WriteLine(@"Choose what you want to do:
                1. Add Marks
                2. Show Marks
                3. Calculate Average
                4. Exit");
                choice = ReadChoice();
                if (choice == MainMenu.Exit)
                {
                    break;
                }

                DoChoiceFromMainMenu(ref gradesEng, gradesHist, ref gradesMath, ref gradesUkr, choice);
            }
        }

        private static void DoChoiceFromMainMenu(ref int[] gradesEng, int[] gradesHist, ref int[] gradesMath, ref int[] gradesUkr, MainMenu choice)
        {
            Console.Clear();
            switch (choice)
            {
                case MainMenu.Add_Marks:
                    SubMenu whatChooseMarks;
                    while (true)
                    {
                        whatChooseMarks = ShowSubmenu();
                        Console.Clear();

                        if (whatChooseMarks == SubMenu.Exit)
                        {
                            break;
                        }

                        switch (whatChooseMarks)
                        {
                            case SubMenu.Mathematics:
                                gradesMath = AddMark(gradesMath);
                                break;
                            case SubMenu.English:
                                gradesEng = AddMark(gradesEng);
                                break;
                            case SubMenu.History:
                                gradesHist = AddMark(gradesHist);
                                break;
                            case SubMenu.Ukrainian:
                                gradesUkr = AddMark(gradesUkr);
                                break;
                        }
                        Console.Clear();
                    }
                    break;

                case MainMenu.Show_Marks:
                    SubMenu whatChooseShow;
                    while(true)
                    {
                        whatChooseShow = ShowSubmenu();
                        Console.Clear();
                        if (whatChooseShow != SubMenu.Exit)
                        {
                            ShowingMarks(gradesEng,  gradesHist,  gradesMath, gradesUkr, whatChooseShow);
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            break;
                        }
                        
                    }
                    return;
                    
                case MainMenu.Calculate_Average:
                    SubMenu whatChooseCalcul;
                    while (true)
                    {
                        whatChooseCalcul = ShowSubmenu();
                        Console.Clear();
                        if (whatChooseCalcul != SubMenu.Exit)
                        {
                            CalculateAverage(gradesEng, gradesHist, gradesMath, gradesUkr, whatChooseCalcul);
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            break;
                        }
                    }
                break;
                case MainMenu.Exit:
                    break;
                default:
                    break;
            }
        }

        private static void AverageItemScore(int[] array)
        {
            int lenghtOfArr = array.Length;
            int sum = 0;
            for (int i = 0; i < lenghtOfArr; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Your average item score is {(double)(sum / lenghtOfArr)}");
        }

        private static void CalculateAverage(int[] gradesEng, int[] gradesHist, int[] gradesMath, int[] gradesUkr, SubMenu whatChooseCalcul)
        {
            switch (whatChooseCalcul)
            {
                case SubMenu.Mathematics:
                    AverageItemScore(gradesMath);
                    break;
                case SubMenu.Ukrainian:
                    AverageItemScore(gradesUkr);
                    break;
                case SubMenu.English:
                    AverageItemScore(gradesEng);
                    break;
                case SubMenu.History:
                    AverageItemScore(gradesHist);
                    break;
                default:
                    break;
            }
        }

        private static void ShowingMarks(int[] gradesEng,  int[] gradesHist,  int[] gradesMath,  int[] gradesUkr, SubMenu whatChooseShow)
        {
            switch (whatChooseShow)
            {
                case SubMenu.Mathematics:
                    ConsoleWriteOfArray( gradesMath);
                    break;
                case SubMenu.Ukrainian:
                    ConsoleWriteOfArray( gradesUkr);
                    break;
                case SubMenu.English:
                    ConsoleWriteOfArray( gradesEng);
                    break;
                case SubMenu.History:
                    ConsoleWriteOfArray( gradesHist);
                    break;
                default:
                    break;
            }
        }

        private static void ConsoleWriteOfArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static int[] AddMark(int[] array, int newMark)
        {
            if (array.Length == 1 && array[0] == 0)
            {
                array[0] = newMark;
                return array;
            }

            array = array.Append(1).ToArray();
            array[array.Length - 1] = newMark;
            return array;
        }

        private static int[] AddMark(int[] array)
        {
            var grade = ReadGrade();

            return AddMark(array, grade);
        }

        //private static int[] FunctionAddMarks(int[] gradesEng, int[] gradesHist, int[] gradesMath, int[] gradesUkr, SubMenu whatChoose)
        //{
        //    var grade = ReadGrade();
        //    switch (whatChoose)
        //    {
        //        case SubMenu.Mathematics:
        //            AddMark( gradesMath, grade);
        //            return gradesMath;
        //            break;
        //        case SubMenu.English:
        //            AddMark( gradesEng, grade);
        //            return gradesEng;
        //            break;
        //        case SubMenu.History:
        //            AddMark( gradesHist, grade);
        //            return gradesHist;
        //            break;
        //        case SubMenu.Ukrainian:
        //            AddMark( gradesUkr, grade);
        //            return gradesUkr;
        //            break;
        //    }
        //}

        private static SubMenu ShowSubmenu()
        {
            Console.WriteLine("Choose subject: ");
            Console.WriteLine("\t1.Mathematics");
            Console.WriteLine("\t2.Ukrainian language");
            Console.WriteLine("\t3.English");
            Console.WriteLine("\t4.History");
            Console.WriteLine("\t5.Exit");
            SubMenu whatChoose = ReadChoice1();
            return whatChoose;
        }

        // TODO figure this out
        private static MainMenu ReadChoice()
        {
            MainMenu choice;
            while (true)
            {
                Console.Write("Write the number: ");
                string input = Console.ReadLine();
                if (MainMenu.TryParse(input, true, out choice) && choice != MainMenu.None && choice < MainMenu.None && choice >= MainMenu.Add_Marks)
                {
                    return choice;
                }
            }
        }

        private static SubMenu ReadChoice1()
        {
            SubMenu choice;
            while (true)
            {
                Console.Write("Write the number: ");
                string input = Console.ReadLine();
                if (SubMenu.TryParse(input, true, out choice) && choice != SubMenu.None && choice < SubMenu.None && choice >= SubMenu.Mathematics)
                {
                    return choice;
                }
            }
        }

        private static int ReadGrade()
        {
            int grade;
            bool isValidInput = false;
            do
            {
                Console.Write("Write your grade for this subject: ");
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out grade);
            }
            while (!isValidInput || grade < 1 || grade > 12);
            return grade;
        }

    }
}
