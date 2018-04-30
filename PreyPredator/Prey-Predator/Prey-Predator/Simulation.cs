using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Prey_Predator
{
    public class Simulation
    {
        public List<IPredator> predators = new List<IPredator>();
        public List<IPrey> preys  = new List<IPrey>();
        public Random random = new Random();
        private readonly MainWindow mainWin = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
        private int rounds = 0;
        public Simulation()
        {
            CreatePredatorList();
            CreatePreys();
            SetLabels();
            mainWin.NextRoundButton.Click += NextRoundButton_Click;
        }

        private void NextRoundButton_Click(object sender, RoutedEventArgs e)
        {
            NextRound();
        }

        private void CreatePredatorList()
        {   
            for (var index = 0; index < 4; index++)
            {
                predators.Add(new Ladybird(random.Next(0, 15), random.Next(0, 15)));
               ((Ladybird) predators[index]).DisplayOn(mainWin.SimulatorCanvas, Colors.Red);
            }
        }

        private void CreatePreys()
        {
            for (var index = 0; index < 100; index++)
            {
                preys.Add(new Louse(random.Next(0, 15), random.Next(0, 15)));
               ((Louse)preys[index]).DisplayOn(mainWin.SimulatorCanvas, Colors.Green);
            }
        }

        public void NextRound()
        {
            rounds++;
            MoveAndAgeInsect();
            ChaseEatAndDie();
            BreedInsects();
            UpdateCanvas();
            SetLabels();
        }

        private void UpdateCanvas()
        {
            mainWin.SimulatorCanvas.Children.Clear();
            foreach (var t in predators)
            {
                ((Ladybird) t).DisplayOn(mainWin.SimulatorCanvas, Colors.Red);
            }

            foreach (var t in preys)
            {
                ((Louse)t).DisplayOn(mainWin.SimulatorCanvas, Colors.Green);
            }

        }

        public void SetLabels()
        {
            mainWin.RoundLabel.Content = rounds;
            mainWin.LadybirdsLabel.Content = predators.Count;
            mainWin.LouseLabel.Content = preys.Count;
        }

        private void MoveAndAgeInsect()
        {
            foreach (var t in predators)
            {
                Random rand =  new Random(random.Next(500));
                int number = rand.Next(1, 8);
                ((Ladybird) t).Age = rounds;
                switch (number)
                {
                    case 1:  
                        ((Ladybird)t).MoveLeft();
                        break;
                    case 2:
                        ((Ladybird)t).MoveForward();
                        break;
                    case 3:
                        ((Ladybird)t).MoveRight();
                        break;
                    case 4:
                        ((Ladybird)t).MoveBackward();
                        break;
                    case 5:
                        ((Ladybird)t).MoveRight();
                        break;
                    case 6:
                        ((Ladybird)t).MoveForward();
                        break;
                    case 7:
                        ((Ladybird)t).MoveBackward();
                        break;
                    case 8:
                        ((Ladybird)t).MoveLeft();
                        break;
                    default:
                        ((Ladybird)t).MoveBackward();
                        break;
                }

                if (((Ladybird) t).XCoord >= 14)
                {
                    ((Ladybird)t).MoveLeft();
                }else if (((Ladybird) t).XCoord <= 1)
                {
                    ((Ladybird)t).MoveRight();
                }else if (((Ladybird) t).YCoord >= 14)
                {
                    ((Ladybird)t).MoveBackward();
                }
                else if (((Ladybird)t).YCoord <= 1)
                {
                    ((Ladybird)t).MoveForward();
                }

            }

            foreach (var t in preys)
            {
                int number = random.Next(1, 8);
                ((Louse)t).Age = rounds;
                switch (number)
                {
                    case 1:
                        ((Louse)t).MoveRight();
                        break;
                    case 2:
                        ((Louse)t).MoveBackward();
                        break;
                    case 3:
                        ((Louse)t).MoveRight();
                        break;
                    case 4:
                        ((Louse)t).MoveForward();
                        break;
                    case 5:
                        ((Louse)t).MoveLeft();
                        break;
                    case 6:
                        ((Louse)t).MoveForward();
                        break;
                    case 7:
                        ((Louse)t).MoveBackward();
                        break;
                    case 8:
                        ((Louse)t).MoveRight();
                        break;
                    default:
                        ((Louse)t).MoveLeft();
                        break;
                }
                if (((Louse)t).XCoord >= 14)
                {
                    ((Louse)t).MoveLeft();
                }
                else if (((Louse)t).XCoord <= 1)
                {
                    ((Louse)t).MoveRight();
                }
                else if (((Louse)t).YCoord >= 14)
                {
                    ((Louse)t).MoveBackward();
                }
                else if (((Louse)t).YCoord <= 1)
                {
                    ((Louse)t).MoveForward();
                }
            }
        }

        private void ChaseEatAndDie()
        {
            List<IPrey> chasedPreys = new List<IPrey>();
            for (var index = 0; index < predators.Count; index++)
            {
                ((Ladybird)predators[index]).Age = rounds;
                chasedPreys = predators[index].Chase(preys);
                predators[index].Eat(chasedPreys);

                if (predators[index].Starving)
                {
                    predators.RemoveAt(index);
                }
            }
        }
        private void BreedInsects()
        {
            int amountOfPredators = predators.Count;
            int amountOfPreys = preys.Count;
            for (int index = 0; index < amountOfPredators; index++)
            {
                if (rounds % 6 == 0)
                {
                    predators.Add(predators[index].Breed());
                }
            }

            for (int index = 0; index < amountOfPreys; index++)
            {
                if (rounds % 5 == 0)
                {
                    preys.Add(preys[index].Breed());
                }
            }
        }
    }
}