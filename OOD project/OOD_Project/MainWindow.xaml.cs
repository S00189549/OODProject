using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        Random rand = new Random();

        List<tbl_BodyPart> AllBodyparts = new List<tbl_BodyPart>();
        ObservableCollection<tbl_Workout> currentWorkout = new ObservableCollection<tbl_Workout>();


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

            var query1 = from profile in db.tbl_Profiles
                         select profile;

            profileComboBox.ItemsSource = query1.ToArray();
            profileComboBox.SelectedIndex = 0;



            //dataGrid.ItemsSource = (from wo in db.tbl_Workout
            //                        select wo).ToList();

            //populate the workout listView
            //workoutBox.ItemsSource = currentWorkout;
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
            tbl_Exercises selectedExercise = exerciseComboBox.SelectedItem as tbl_Exercises;

            repsComboBox.SelectedIndex = selectedExercise.Reps - 1;

            setsComboBox.SelectedIndex = selectedExercise.Sets - 1;


            //ExerciseImage.Source = new BitmapImage(new Uri(imageFileName, UriKind.Relative));
            //ImageSource IS = ExerciseImage.Source;
        }


        int[] GetNumbers(int max)
        {
            int[] result = new int[max];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = i + 1;
            }
            return result;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            saveButton.IsEnabled = true;
            tbl_Exercises selectedExercise = exerciseComboBox.SelectedItem as tbl_Exercises;
            int selectedReps = repsComboBox.SelectedIndex + 1;
            int selectedSets = setsComboBox.SelectedIndex + 1;


            tbl_Workout exerciseToAdd = new tbl_Workout()
            {
                ExerciseID = selectedExercise.Id,
                Name = selectedExercise.Name,
                Reps = selectedReps,
                Sets = selectedSets,
                TUT = checkBoxTUT.IsChecked,
                Pause = checkBoxPause.IsChecked,
                C1_5xReps = checkBox1_5Reps.IsChecked
            };

            currentWorkout.Add(exerciseToAdd);
            workoutBox.ItemsSource = (from w in currentWorkout
                                      select new
                                      {
                                          Name = w.Name,
                                          Reps = w.Reps,
                                          Sets = w.Sets,
                                          TUT = w.TUT,
                                          Pause = w.Pause,
                                          _1_5X_Reps = w.C1_5xReps
                                      }).ToArray();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            int index = workoutBox.SelectedIndex;
            currentWorkout.RemoveAt(index);
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            saveButton.IsEnabled = false;
            tbl_Profiles selectedProfile = profileComboBox.SelectedItem as tbl_Profiles;

            for (int i = 0; i < currentWorkout.Count; i++)
            {
                currentWorkout[i].SaveDate = DateTime.Now;
                currentWorkout[i].ProfileID = selectedProfile.Id;
                currentWorkout[i].Id = selectedProfile.tbl_Workout.Count + i + 1;
                db.tbl_Workout.Add(currentWorkout[i]);
            }
            workoutBox.ItemsSource = null;
            currentWorkout.Clear();
            db.SaveChanges();
        }
    }
}
