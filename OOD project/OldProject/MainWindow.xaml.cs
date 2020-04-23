
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Data;


namespace OOD_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        AdilsGymEntities db = new AdilsGymEntities();

        List<tbl_BodyPart> AllBodyparts = new List<tbl_BodyPart>();

        //List<Exercise> allExercises;
        //List<Exercise> Chest;
        //List<Exercise> Back;
        //List<Exercise> Bicep; 
        //List<Exercise> Tricep;
        //List<Exercise> Shoulders;
        //List<Exercise> Quads;
        //List<Exercise> Hamstrings;
        //List<Exercise> Glutes;
        //List<Exercise> Calves;
        //List<Exercise> Forearms;

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
        }
        
        //public List<Exercise> GetExercises()
        //{
        //    List<Exercise> allExercises = new List<Exercise>();

        //    // Chest Exercises
        //    Exercise Chest1 = new Exercise()
        //    {
        //        exerciseName = "Bench Press",
                
        //        description = "The person performing the exercise lies on their back on a bench with a barbell grasped in both hands. They lower the barbell to chest level, then press the barbell upwards, extending the arms until the elbows are locked out. This is one repetition (rep)."
        //    };
        //    Exercise Chest2 = new Exercise()
        //    {
        //        exerciseName = "",

        //        description = ""
        //    };
        //    // Back Exercises
        //    Exercise Back1 = new Exercise()
        //    {
        //        exerciseName = "Pullup",

        //        description = "Standard dead-hang pull up is grasped with an overhand/underhand/alternative-hand grip. Then the body is pulled up until the chin clears the bar, and finished by lowering the body until arms and shoulders are fully extended."
        //    };
        //    Exercise Back2 = new Exercise()
        //    {
        //        exerciseName = "",

        //        description = ""
        //    };
        //    // Bicep Exercises
        //    Exercise Bicep1 = new Exercise()
        //    {
        //        exerciseName = "Bicep Curl",

        //        description = "This movement usually starts from the elbows and is in a fully extended position (against thigh)with a supinated grip. Then biceps begin contracting to lift the weight, upward to shoulder. The second part of the motion is the eccentric phase that has the elbow joint slowly extending as weight is lowering back to the starting position."
        //    };
        //    Exercise Bicep2 = new Exercise()
        //    {
        //        exerciseName = "",

        //        description = ""
        //    };
        //    // Tricep Exercises
        //    Exercise Tricep1 = new Exercise()
        //    {
        //        exerciseName = "Dip",

        //        description = ""
        //    };
        //    Exercise Tricep2 = new Exercise()
        //    {
        //        exerciseName = "",

        //        description = ""
        //    };
        //    // Shoulder Exercises
        //    Exercise Shoulders1 = new Exercise()
        //    {
        //        exerciseName = "Overhead Press",

        //        description = ""
        //    };
        //    Exercise Shoulders2 = new Exercise()
        //    {
        //        exerciseName = "",

        //        description = ""
        //    };
        //    // Quad Exercises
        //    Exercise Quads1 = new Exercise()
        //    {
        //        exerciseName = "Squat",

        //        description = ""
        //    };
        //    Exercise Quads2 = new Exercise()
        //    {
        //        exerciseName = "",

        //        description = ""
        //    };
        //    // Hamstring Exercises
        //    Exercise Hamstrings1 = new Exercise()
        //    {
        //        exerciseName = "Hamstring Curl",

        //        description = ""
        //    };
        //    Exercise Hamstrings2 = new Exercise()
        //    {
        //        exerciseName = "",

        //        description = ""
        //    };
        //    // Glute Exercises
        //    Exercise Glutes1 = new Exercise()
        //    {
        //        exerciseName = "Deadlift",

        //        description = ""
        //    };
        //    Exercise Glutes2 = new Exercise()
        //    {
        //        exerciseName = "",

        //        description = ""
        //    };
        //    // Calve Exercises
        //    Exercise Calves1 = new Exercise()
        //    {
        //        exerciseName = "Calf Raises",

        //        description = ""
        //    };
        //    Exercise Calves2 = new Exercise()
        //    {
        //        exerciseName = "",

        //        description = ""
        //    };
        //    // Forearm Exercises
        //    Exercise Forearms1 = new Exercise()
        //    {
        //        exerciseName = "Forearm Curl",

        //        description = ""
        //    };
        //    Exercise Forearms2 = new Exercise()
        //    {
        //        exerciseName = "",

        //        description = ""
        //    };

        //    return allExercises;
        //}

        //private void addButton_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void deleteButton_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void saveButton_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void timeUnderTensionRadioButton_Checked(object sender, RoutedEventArgs e)
        //{

        //}

        //private void pauseRadioButton_Checked(object sender, RoutedEventArgs e)
        //{

        //}

        //private void _1_5xRepsRadioButton_Checked(object sender, RoutedEventArgs e)
        //{

        //}

        //private void Grid_Loaded(object sender, RoutedEventArgs e)
        //{
        //    Load_List();
        //}
        //#region Methods

        //private void Load_List()
        //{
        //    //string con_string = Properties.Settings.Default.ExerciseDatabaseConnectionString;
        //    //SqlConnection con_connection = new SqlConnection(con_string);
        //    //if (con_connection.State != System.Data.ConnectionState.Open) 
        //    //{
        //    //    con_connection.Open();
        //    //}

        //    //string sql_Text = "SELECT * FROM tbl_Exercise";

        //    //DataTable tbl = new DataTable();
        //    //SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, con_connection);


        //    //ListBox.DataContext= tbl;

            
            
            
        //}



   

    }
}
