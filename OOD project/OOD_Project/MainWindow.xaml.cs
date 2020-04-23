using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOD_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AdilsGymEntities db = new AdilsGymEntities();

        List<tbl_BodyPart> AllBodyparts = new List<tbl_BodyPart>();
        List<tbl_Workout> currentWorkout = new List<tbl_Workout>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from bp in db.tbl_BodyPart
                        select bp;

            AllBodyparts = query.ToList();
            bodyPartComboBox.ItemsSource = AllBodyparts;
            bodyPartComboBox.SelectedIndex = 0;


            repsComboBox.ItemsSource = GetNumbers(25);
            setsComboBox.ItemsSource = GetNumbers(10);

        }

        private void bodyPartComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbl_BodyPart seletedBodyPart = (bodyPartComboBox.SelectedItem as tbl_BodyPart);

            bool isAllSelected = seletedBodyPart.Name.Equals("All");

            int bodyPartId = seletedBodyPart.Id;


            if (bodyPartId <= 0) return;

            var query = from ex in db.tbl_Exercises
                        where ex.BodyPartID == bodyPartId || isAllSelected
                        select ex;

            exerciseComboBox.ItemsSource = query.ToList();
            exerciseComboBox.SelectedIndex = 0;

        }

        private void exerciseComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbl_Exercises selectedExercise= exerciseComboBox.SelectedItem as tbl_Exercises;

            repsComboBox.SelectedIndex = selectedExercise.Reps -1;

            setsComboBox.SelectedIndex = selectedExercise.Sets -1;


            //ExerciseImage.Source = new BitmapImage(new Uri(imageFileName, UriKind.Relative));
            //ImageSource IS = ExerciseImage.Source;
        }


        int[] GetNumbers(int max)
        {
            int[] result = new int[max];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = i+1;
            }
            return result;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            tbl_Exercises selectedExercise = exerciseComboBox.SelectedItem as tbl_Exercises;
            int selectedReps = repsComboBox.SelectedIndex + 1;
            int selectedSets = setsComboBox.SelectedIndex + 1;


            tbl_Workout exerciseToAdd = new tbl_Workout()
            {
                Name = selectedExercise.Name,
                Reps = selectedReps,
                Sets = selectedSets,
                TUT = checkBoxTUT.IsChecked,
                Pause = checkBoxPause.IsChecked,
                C1_5xReps = checkBox1_5Reps.IsChecked
            };

            currentWorkout.Add(exerciseToAdd);

            workoutBox.ItemsSource = currentWorkout;

        }
    }
}
