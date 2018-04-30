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
            ChaseAndEat();
            BreedInsects();
            UpdateCanvas();
            SetLabels();
        }

        private void UpdateCanvas()
        {
            mainWin.SimulatorCanvas.Children.Clear();
            for (var index = 0; index < predators.Count; index++)
            {
                ((Ladybird) predators[index]).DisplayOn(mainWin.SimulatorCanvas, Colors.Red);              
            }

            for (var index = 0; index < preys.Count; index++)
            {
              
                ((Louse)preys[index]).DisplayOn(mainWin.SimulatorCanvas, Colors.Green);
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
           
            for (var index = 0; index < predators.Count; index++)
            {
                int number = random.Next(1, 8);
                ((Ladybird) predators[index]).Age = rounds;
                switch (number)
                {
                    case 1:  
                        ((Ladybird)predators[index]).MoveLeft();
                        break;
                    case 2:
                        ((Ladybird)predators[index]).MoveForward();
                        break;
                    case 3:
                        ((Ladybird)predators[index]).MoveRight();
                        break;
                    case 4:
                        ((Ladybird)predators[index]).MoveBackward();
                        break;
                    case 5:
                        ((Ladybird)predators[index]).MoveRight();
                        break;
                    case 6:
                        ((Ladybird)predators[index]).MoveForward();
                        break;
                    case 7:
                        ((Ladybird)predators[index]).MoveBackward();
                        break;
                    case 8:
                        ((Ladybird)predators[index]).MoveLeft();
                        break;
                    default:
                        ((Ladybird)predators[index]).MoveBackward();
                        break;
                }
                
            }

            for (var index = 0; index < preys.Count; index++)
            {
                int number = random.Next(1, 8);
                ((Louse)preys[index]).Age = rounds;
                switch (number)
                {
                    case 1:
                        ((Louse)preys[index]).MoveRight();
                        break;
                    case 2:
                        ((Louse)preys[index]).MoveBackward();
                        break;
                    case 3:
                        ((Louse)preys[index]).MoveRight();
                        break;
                    case 4:
                        ((Louse)preys[index]).MoveForward();
                        break;
                    case 5:
                        ((Louse)preys[index]).MoveLeft();
                        break;
                    case 6:
                        ((Louse)preys[index]).MoveForward();
                        break;
                    case 7:
                        ((Louse)preys[index]).MoveBackward();
                        break;
                    case 8:
                        ((Louse)preys[index]).MoveRight();
                        break;
                    default:
                        ((Louse)preys[index]).MoveLeft();
                        break;
                }

            }
        }

        private void ChaseAndEat()
        {
            List<IPrey> chasedPreys = new List<IPrey>();
            for (var index = 0; index < predators.Count; index++)
            {
                ((Ladybird)predators[index]).Age = rounds;
                chasedPreys = predators[index].Chase(preys);
                predators[index].Eat(chasedPreys);
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